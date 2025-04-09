using XenonAPI.Models;
using XenonAPI.Repositories.Contracts;
using XenonAPI.Services.Contracts;

namespace XenonAPI.Services.Implementation
{
    public class RoomService :IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IGenericRepository<Room> roomRepository)
        {
        }

        public Task<IEnumerable<Room>> GetOccupiedAsync()
        {
            return _roomRepository.GetAllOccupiedRoomsAsync();
        }

        public async Task AddAsync(Room entity)
        {
            await _roomRepository.AddAsync(entity);
        }

        public Task<IEnumerable<Room>> GetVacantAsync()
        {
            return _roomRepository.GetAllVacantRoomsAsync(); 
        }

        public Task<IEnumerable<Room>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Room entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Room> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
