using Microsoft.EntityFrameworkCore;
using ProjectM.model;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectM.controller
{
    internal class UsersController<T> : DbContext where T : class
    {
        public DbSet<UsersModel<T>> Users { get; protected set; }
        public UsersController()
        {
            Database.EnsureCreatedAsync();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings[name: "AppDb"].ConnectionString);
        }
    }
}
 