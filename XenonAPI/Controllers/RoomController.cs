using Microsoft.AspNetCore.Mvc;
using XenonAPI.Models;
using XenonAPI.Services.Contracts;
namespace XenonAPI.Controllers
{

    [ApiController]
    [Route("api/rooms")]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _roomService.GetAllAsync());
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var room = await _roomService.GetByIdAsync(id);
            return room != null ? Ok(room) : NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Room room)
        {
            await _roomService.AddAsync(room);
            return CreatedAtAction(nameof(GetById), new { id = room.Id }, room);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Room room)
        {
            if (id != room.Id) return BadRequest();
            await _roomService.UpdateAsync(room);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _roomService.DeleteAsync(id);
            return NoContent();
        }
        [HttpGet("vacant")]
        public async Task<IActionResult> GetVacant() => Ok(await _roomService.GetVacantAsync());
        [HttpGet("occupied")]
        public async Task<IActionResult> GetOccupied() => Ok(await _roomService.GetOccupiedAsync());
    }
}
