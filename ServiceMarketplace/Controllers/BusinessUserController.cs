using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessUserController : ControllerBase
    {

        private readonly IServiceMarketplaceRepository _repository;

        public BusinessUserController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<BusinessUser>> Get()
        {
            return await _repository.GetAllBusinessUsersAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var business = await _repository.GetBusinessUsersByIdAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return Ok(business);
        }

        [HttpPost]
        public async Task<IActionResult> Add(BusinessUser business)
        {
            await _repository.AddBusinessUsersAsync(business);
            return CreatedAtAction(nameof(GetById), new { id = business.Id }, business);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, BusinessUser business)
        {
            if (id != business.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateBusinessUsersAsync(business);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteBusinessUsersAsync(id);
            return NoContent();
        }
    }
}
