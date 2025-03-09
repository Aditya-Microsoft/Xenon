using XenonAPI.Models;

namespace XenonAPI.Repositories.Contracts
{
    public interface ITenantRepository : IGenericRepository<Tenant>
    {
        Task<IEnumerable<Tenant>> GetUpcomingRentDueAsync();
        Task<IEnumerable<Tenant>> GetVacatingSoonAsync();
    }

}
