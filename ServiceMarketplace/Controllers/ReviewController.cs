using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {

        private readonly IServiceMarketplaceRepository _repository;

        public ReviewController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Review>> Get()
        {
            return await _repository.GetAllReviewsAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Review = await _repository.GetReviewsByIdAsync(id);
            if (Review == null)
            {
                return NotFound();
            }
            return Ok(Review);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Review review)
        {
            await _repository.AddReviewsAsync(review);
            return CreatedAtAction(nameof(GetById), new { id = review.Id }, review);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Review review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateReviewsAsync(review);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteReviewsAsync(id);
            return NoContent();
        }
    }
}
