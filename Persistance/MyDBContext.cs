using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using students_task.Domain.Models;
using students_task.Application.Interfaces;
namespace students_task.Persistance
{
    public class MyDBContext : DbContext, IMyDbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> opts) : base(opts) {
            
            //Database.EnsureCreated();
        }
        public DbSet<User> Users{get; private set;}
        public DbSet<Product> Products{get; private set;}
        public DbSet<Dept> Depts{get; private set;}
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            var r = await base.SaveChangesAsync(cancellationToken);
            return r;
        }
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyDBContext).Assembly);
        }
    }
}