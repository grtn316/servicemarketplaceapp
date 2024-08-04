using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {

        private readonly IServiceMarketplaceRepository _repository;

        public ServiceController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<object>> Get()
        {
            return await _repository.GetAllServicesAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Service = await _repository.GetServicesByIdAsync(id);
            if (Service == null)
            {
                return NotFound();
            }
            return Ok(Service);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Service service)
        {
            await _repository.AddServicesAsync(service);
            return CreatedAtAction(nameof(GetById), new { id = service.Id }, service);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Service service)
        {
            if (id != service.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateServicesAsync(service);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteServicesAsync(id);
            return NoContent();
        }
    }
}
