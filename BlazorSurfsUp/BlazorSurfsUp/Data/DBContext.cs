using BlazorSurfsUp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorSurfsUp.Data
{
    public class DBContext:IdentityUserContext<User>
    {
        public DbSet<ShopItem> shopItems { get; set; }
        public DbSet<SpotComment> SpotComments { get; set; }
        public DbSet<Spot> Spots { get; set; }
        private readonly IHttpContextAccessor _httpContextaccessor;
        public DBContext(DbContextOptions options, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextaccessor = httpContextAccessor;
        }
    }
}
