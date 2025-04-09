using XenonAPI.Models;

namespace XenonAPI.Repositories.Contracts
{
    public interface IRoomRepository: IGenericRepository<Room>
    {
        Task<IEnumerable<Room>> GetAllVacantRoomsAsync();
        Task<IEnumerable<Room>> GetAllOccupiedRoomsAsync();
        

    }
}
