using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceAvailabilityController : ControllerBase
    {

        private readonly IServiceMarketplaceRepository _repository;

        public ServiceAvailabilityController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public async Task<IEnumerable<ServiceAvailability>> Get()
        {
            return await _repository.GetAllServiceAvailabilityAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var ServiceAvailability = await _repository.GetServiceAvailabilityByIdAsync(id);
            if (ServiceAvailability == null)
            {
                return NotFound();
            }
            return Ok(ServiceAvailability);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ServiceAvailability serviceAvailability)
        {
            await _repository.AddServiceAvailabilityAsync(serviceAvailability);
            return CreatedAtAction(nameof(GetById), new { id = serviceAvailability.Id }, serviceAvailability);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ServiceAvailability serviceAvailability)
        {
            if (id != serviceAvailability.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateServiceAvailabilityAsync(serviceAvailability);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteServiceAvailabilityAsync(id);
            return NoContent();
        }
    }
}
