using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IServiceMarketplaceRepository _repository;

        public UserController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _repository.GetAllUsersAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _repository.GetUsersByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            await _repository.AddUsersAsync(user);
            return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, User user)
        {
            if (id != user.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateUsersAsync(user);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteUsersAsync(id);
            return NoContent();
        }
    }
}
