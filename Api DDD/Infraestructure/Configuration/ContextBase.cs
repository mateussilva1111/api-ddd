using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Configuration;


namespace Infraestructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
        }
        
        public DbSet<Message> Messagr { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuider)
        {
            if (!optionsBuider.IsConfigured)
            {
                optionsBuider.UseMySQL(ObterStringConexao());
            }
            base.OnConfiguring(optionsBuider);
            //ConnectionStringSettings appsetings
            //{
            //    "ConnectionStrings": {
            //        "DefaultConnection": "Server=localhost;Database=bancoddd;User=root;Password=admin;"
            //    }
            //}
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }


        public string ObterStringConexao()
        {
            return "Server=localhost;DataBase=bancoddd;Uid=root;Pwd=admin";
        }

    }
}
