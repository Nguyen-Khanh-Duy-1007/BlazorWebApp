using BlazorWebApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebApp.Persistence.Contexts
{
    public class BlazorWebAppContext : DbContext
    {
        public BlazorWebAppContext(DbContextOptions<BlazorWebAppContext> options) 
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithOne(e => e.Department)
                .HasForeignKey<Employee>(e => e.DepartmentID);

            base.OnModelCreating(modelBuilder);
        }

        DbSet<Employee> Employee { get; set; }
        DbSet<Department> Department { get; set; }
    }
}
