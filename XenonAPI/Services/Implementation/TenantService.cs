using XenonAPI.Models;
using XenonAPI.Repositories.Contracts;
using XenonAPI.Services.Contracts;

namespace XenonAPI.Services.Implementation
{
    public class TenantService : ITenantService
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantService(IGenericRepository<Tenant> tenantRepository)
        {
        }

        public Task AddAsync(Tenant entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tenant>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tenant> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tenant>> GetUpcomingRentDueAsync()
        {
            return _tenantRepository.GetUpcomingRentDueAsync();
        }

        public Task<IEnumerable<Tenant>> GetVacatingSoonAsync()
        {
            return _tenantRepository.GetVacatingSoonAsync();
        }

        public Task UpdateAsync(Tenant entity)
        {
            throw new NotImplementedException();
        }
    }
}
