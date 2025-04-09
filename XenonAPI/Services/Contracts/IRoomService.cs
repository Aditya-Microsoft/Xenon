using XenonAPI.Models;

namespace XenonAPI.Services.Contracts
{
    public interface IRoomService
    {
        Task<IEnumerable<Room>> GetVacantAsync();
        Task<IEnumerable<Room>> GetOccupiedAsync();
        Task AddAsync(Room entity);
        Task <IEnumerable<Room>> GetAllAsync();
        Task UpdateAsync(Room entity);
        Task DeleteAsync(int id);
        Task<Room> GetByIdAsync(int id);
    }
}
