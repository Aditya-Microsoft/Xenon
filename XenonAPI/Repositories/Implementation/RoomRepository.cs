using Microsoft.EntityFrameworkCore;
using XenonAPI.Database;
using XenonAPI.Models;
using XenonAPI.Repositories.Contracts;

namespace XenonAPI.Repositories.Implementation
{
    public class RoomRepository: GenericRepository<Room>, IRoomRepository
    {
        private readonly ApplicationDbContext _context;
        public RoomRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Room>> GetAllVacantRoomsAsync()
        {
            // return rooms where capacity is greater than occupied beds
            return await _dbSet.Where(r => r.Capacity > r.OccupiedBeds).ToListAsync();
        }
        public async Task<IEnumerable<Room>> GetAllOccupiedRoomsAsync()
        {
            return await _dbSet.Where(r => r.Capacity == r.OccupiedBeds).ToListAsync();
        }
    }
}
