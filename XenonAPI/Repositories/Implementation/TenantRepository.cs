using Microsoft.EntityFrameworkCore;
using XenonAPI.Database;
using XenonAPI.Models;
using XenonAPI.Repositories.Contracts;

namespace XenonAPI.Repositories.Implementation
{
    public class TenantRepository : GenericRepository<Tenant>, ITenantRepository
    {
        private readonly ApplicationDbContext _context;

        public TenantRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tenant>> GetUpcomingRentDueAsync()
        {
            return await _dbSet.Where(t => t.RentDueDate <= DateTime.UtcNow.AddDays(7)).ToListAsync();
        }

        public async Task<IEnumerable<Tenant>> GetVacatingSoonAsync()
        {
            return await _dbSet.Where(t => t.IsVacatingSoon).ToListAsync();
        }
    }

}
