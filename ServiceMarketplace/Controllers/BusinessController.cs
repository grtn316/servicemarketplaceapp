using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessController : ControllerBase
    {
        private readonly IServiceMarketplaceRepository _repository;

        public BusinessController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Business>> Get()
        {
            return await _repository.GetAllBusinessesAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var business = await _repository.GetBusinessesByIdAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return Ok(business);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Business business)
        {
            await _repository.AddBusinessesAsync(business);
            return CreatedAtAction(nameof(GetById), new { id = business.Id }, business);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Business business)
        {
            if (id != business.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateBusinessesAsync(business);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteBusinessesAsync(id);
            return NoContent();
        }
    }
}
