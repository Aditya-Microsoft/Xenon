using Microsoft.AspNetCore.Mvc;
using XenonAPI.Models;
using XenonAPI.Services.Contracts;

namespace XenonAPI.Controllers
{
    [ApiController]
    [Route("api/tenants")]
    public class TenantController : ControllerBase
    {
        private readonly ITenantService _tenantService;

        public TenantController(ITenantService tenantService)
        {
            _tenantService = tenantService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _tenantService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var tenant = await _tenantService.GetByIdAsync(id);
            return tenant != null ? Ok(tenant) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Tenant tenant)
        {
            await _tenantService.AddAsync(tenant);
            return CreatedAtAction(nameof(GetById), new { id = tenant.Id }, tenant);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Tenant tenant)
        {
            if (id != tenant.Id) return BadRequest();
            await _tenantService.UpdateAsync(tenant);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tenantService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("upcoming-rent-due")]
        public async Task<IActionResult> GetUpcomingRentDue() => Ok(await _tenantService.GetUpcomingRentDueAsync());

        [HttpGet("vacating-soon")]
        public async Task<IActionResult> GetVacatingSoon() => Ok(await _tenantService.GetVacatingSoonAsync());
    }

}
