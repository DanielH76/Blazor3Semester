using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BlazorSurfsUp.Models
{
    public interface IDatabase <T> 
    {
        public Task<T> Get(string id);
        public Task<IReadOnlyCollection<T>> GetAll();
        public Task<T> Add(T @object);
        public Task Update(T @object);
        public Task Delete(T @object);
        public Task<IReadOnlyCollection<T>> Where(Expression<Func<T, bool>> condition);
        public Task<T> FirstOrDefault(Expression<Func<T, bool>> condition);
    }
}
