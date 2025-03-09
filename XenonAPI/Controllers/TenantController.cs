using Microsoft.AspNetCore.Mvc;
using XenonAPI.Models;
using XenonAPI.Repositories.Contracts;

namespace XenonAPI.Controllers
{
    [ApiController]
    [Route("api/tenants")]
    public class TenantController : ControllerBase
    {
        private readonly ITenantRepository _tenantRepository;

        public TenantController(ITenantRepository tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _tenantRepository.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tenant = await _tenantRepository.GetByIdAsync(id);
            return tenant != null ? Ok(tenant) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tenant tenant)
        {
            await _tenantRepository.AddAsync(tenant);
            return CreatedAtAction(nameof(GetById), new { id = tenant.Id }, tenant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Tenant tenant)
        {
            if (id != tenant.Id) return BadRequest();
            await _tenantRepository.UpdateAsync(tenant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tenantRepository.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("upcoming-rent-due")]
        public async Task<IActionResult> GetUpcomingRentDue() => Ok(await _tenantRepository.GetUpcomingRentDueAsync());

        [HttpGet("vacating-soon")]
        public async Task<IActionResult> GetVacatingSoon() => Ok(await _tenantRepository.GetVacatingSoonAsync());
    }

}
