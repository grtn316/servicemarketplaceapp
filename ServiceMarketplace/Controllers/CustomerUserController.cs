using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerUserController : ControllerBase
    {

        private readonly IServiceMarketplaceRepository _repository;

        public CustomerUserController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<CustomerUser>> Get()
        {
            return await _repository.GetAllCustomerUsersAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var CustomerUser = await _repository.GetCustomerUsersByIdAsync(id);
            if (CustomerUser == null)
            {
                return NotFound();
            }
            return Ok(CustomerUser);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerUser customerUser)
        {
            await _repository.AddCustomerUsersAsync(customerUser);
            return CreatedAtAction(nameof(GetById), new { id = customerUser.Id }, customerUser);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CustomerUser customerUser)
        {
            if (id != customerUser.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateCustomerUsersAsync(customerUser);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteCustomerUsersAsync(id);
            return NoContent();
        }
    }
}
