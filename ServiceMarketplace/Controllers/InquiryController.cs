using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InquiryController : ControllerBase
    {

        private readonly IServiceMarketplaceRepository _repository;

        public InquiryController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Inquiry>> Get()
        {
            return await _repository.GetAllInquiriesAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Inquiry = await _repository.GetInquiriesByIdAsync(id);
            if (Inquiry == null)
            {
                return NotFound();
            }
            return Ok(Inquiry);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Inquiry inquiry)
        {
            await _repository.AddInquiriesAsync(inquiry);
            return CreatedAtAction(nameof(GetById), new { id = inquiry.Id }, inquiry);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Inquiry inquiry)
        {
            if (id != inquiry.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateInquiriesAsync(inquiry);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteInquiriesAsync(id);
            return NoContent();
        }
    }
}
