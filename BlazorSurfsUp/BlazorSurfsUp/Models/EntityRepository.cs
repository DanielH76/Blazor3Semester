using BlazorSurfsUp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorSurfsUp.Models
{
    public class EntityRepository<T>:IDatabase<Task> where T : BaseEntity
    {
        private readonly IConfiguration _config;
        private readonly DBContext _context;

        public EntityRepository(IConfiguration config, DBContext context)
        {
            _config = config;
            _context = context;
        }

        public async Task<T> Add(T @object)
        {
            await _context.Set<T>().AddAsync(@object);
            await _context.SaveChangesAsync();
            return @object;
        }

        public async Task<Task> Delete(T @object)
        {
            _context.Set<T>().Remove(@object);
            await _context.SaveChangesAsync();
            return 
        }

        public async Task<T> Get(string id) => await _context.Set<T>().Where(e => e.ID == id).FirstOrDefaultAsync();

        public async Task<IReadOnlyCollection<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();

        }

        public async Task Update(T @object)
        {
            _context.Set<T>().Update(@object);
            await _context.SaveChangesAsync();

        }

        public async Task<IReadOnlyCollection<T>> Where(Expression<Func<T, bool>> condition)
        {
            return await _context.Set<T>().Where(condition).ToListAsync();
        }

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> condition)
        {
            return await _context.Set<T>().Where(condition).FirstOrDefaultAsync();

        }

    }
}
