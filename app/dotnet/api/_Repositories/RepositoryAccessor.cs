using api.Data;
using api.Models;
using Microsoft.EntityFrameworkCore.Storage;

namespace API._Repositories
{
    public class RepositoryAccessor : IRepositoryAccessor
    {
        private DBContext _context;

        public RepositoryAccessor(DBContext context)
        {
            _context = context;

            Customer = new Repository<Customer>(_context);

            Order = new Repository<Order>(_context);

        }


        public IRepository<Customer> Customer { get; private set; }

        public IRepository<Order> Order { get; private set; }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }
    }
}