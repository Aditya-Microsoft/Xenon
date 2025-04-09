

using XenonAPI.Models;

namespace XenonAPI.Services.Contracts
{
    public interface ITenantService
    {
        Task<IEnumerable<Tenant>> GetUpcomingRentDueAsync();
        Task<IEnumerable<Tenant>> GetVacatingSoonAsync();
        Task<IEnumerable<Tenant>> GetAllAsync();
        Task AddAsync(Tenant entity);
        Task UpdateAsync(Tenant entity);
        Task DeleteAsync(int id);
        Task<Tenant> GetByIdAsync(int id);
    }
}
