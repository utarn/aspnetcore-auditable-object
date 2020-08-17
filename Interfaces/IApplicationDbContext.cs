using System.Threading.Tasks;
using aspnetcore_auditable.Data;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_auditable.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; set; }
        Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}