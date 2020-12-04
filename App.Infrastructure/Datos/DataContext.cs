using App.Core.Entities;
using App.Core.Entities.BD_Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Datos
{
    public partial class DataContext : IdentityDbContext<User>
    {
        public virtual DbSet<Category> category { get; set; }
        public virtual DbSet<Client> client { get; set; }
        public virtual DbSet<Product> product { get; set; }

        private const string conection = "server=localhost;port=3306;database=bdapp;user=root;password=";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                /*
                 * To protect potentially sensitive information in your connection string, you should move it out of source code. 
                 * See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                 */

                optionsBuilder.UseMySql(conection);
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}