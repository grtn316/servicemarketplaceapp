using Microsoft.AspNetCore.Mvc;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceMarketplace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IServiceMarketplaceRepository _repository;

        public BookingController(IServiceMarketplaceRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IEnumerable<Booking>> Get()
        {
            return await _repository.GetAllBookingsAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var Booking = await _repository.GetBookingsByIdAsync(id);
            if (Booking == null)
            {
                return NotFound();
            }
            return Ok(Booking);
        }

        [HttpGet("/customer/{customerId}")]
        public async Task<IActionResult> GetByCustomerId(string customerId)
        {
            var Booking = await _repository.GetBookingsByCustomerIdAsync(customerId);
            if (Booking == null)
            {
                return NotFound();
            }
            return Ok(Booking);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Booking Booking)
        {
            await _repository.AddBookingsAsync(Booking);
            return CreatedAtAction(nameof(GetById), new { id = Booking.Id }, Booking);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Booking Booking)
        {
            if (id != Booking.Id)
            {
                return BadRequest();
            }

            await _repository.UpdateBookingsAsync(Booking);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _repository.DeleteBookingsAsync(id);
            return NoContent();
        }
    }
}
