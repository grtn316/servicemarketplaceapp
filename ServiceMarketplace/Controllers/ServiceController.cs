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

        [HttpGet] // GET /api/service
        public async Task<IEnumerable<Service>> Get()
        {
            return await _repository.GetAllServicesAsync();
        }

        [HttpGet("{id}")] // GET /api/service/id
        public async Task<IActionResult> GetById(int id)
        {
            var Service = await _repository.GetServicesByIdAsync(id);
            if (Service == null)
            {
                return NotFound();
            }
            return Ok(Service);
        }

        [HttpPost] // POST /api/service
        //public async Task<IActionResult> Add(Service service)
        public void Add([FromForm] Service service)
        {
            //await _repository.AddServicesAsync(service);
            //return CreatedAtAction(nameof(GetById), new { id = service.Id }, service);
            // CreatedAtAction returns status code

            // DEBUGGING: breakpoint HERE what the populated Service object looks like
            var test = 0;
        }

        [HttpPut("{id}")] // PUT /api/service/id
        public async Task<IActionResult> Update(int id, Service service)
        {
            if (id != service.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateServicesAsync(service);
            return NoContent();
        }

        [HttpDelete("{id}")] // DELETE /api/service/id
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteServicesAsync(id);
            return NoContent();
        }
    }
}
