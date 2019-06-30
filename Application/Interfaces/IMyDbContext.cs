using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;
using students_task.Domain.Models;

namespace students_task.Application.Interfaces
{
    public interface IMyDbContext
    {
        DbSet<User> Users{ get; }
        DbSet<Product> Products{ get; }
        DbSet<Dept> Depts{ get; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);   
    }
}
