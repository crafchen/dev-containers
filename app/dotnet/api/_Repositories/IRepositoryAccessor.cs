using api.Configurations;
using api.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace API._Repositories
{
    [DependencyInjectionAttribute(ServiceLifetime.Scoped)]
    public interface IRepositoryAccessor
    {
        IRepository<Customer> Customer { get; }
        IRepository<Order> Order { get; }

        Task<bool> SaveChangesAsync();
        Task<IDbContextTransaction> BeginTransactionAsync();
    }
}