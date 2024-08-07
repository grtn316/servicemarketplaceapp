﻿using Microsoft.AspNetCore.Mvc;
using Moq;
using ServiceMarketplace.Controllers;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ServiceMarketplace.Tests
{
    public class BookingControllerTests
    {
        private readonly Mock<IServiceMarketplaceRepository> _mockRepo;
        private readonly BookingController _controller;

        public BookingControllerTests()
        {
            _mockRepo = new Mock<IServiceMarketplaceRepository>();
            _controller = new BookingController(_mockRepo.Object);
        }

        [Fact]
        public async Task Get_ReturnsAllBookings()
        {
            
            var bookings = new List<Booking>
            {
                new Booking { Id = 1, ServiceId = 1, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", Status = BookingStatus.Confirmed },
            new Booking { Id = 2, ServiceId = 2, CustomerId = "1633f073-0193-4bed-815e-db4cdeaf4713", Status = BookingStatus.Canceled }
            };
            _mockRepo.Setup(repo => repo.GetAllBookingsAsync()).ReturnsAsync(bookings);

            
            var result = await _controller.Get();

            
            Assert.Equal(bookings, result);
        }

        [Fact]
        public async Task GetById_ReturnsNotFound_WhenBookingDoesNotExist()
        {
            
            _mockRepo.Setup(repo => repo.GetBookingsByIdAsync(It.IsAny<int>())).ReturnsAsync((Booking?)null);

            
            var result = await _controller.GetById(1);

            
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsBooking_WhenBookingExists()
        {

            var bookings = new Booking { Id = 1, ServiceId = 1, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", Status = BookingStatus.Confirmed };
            _mockRepo.Setup(repo => repo.GetBookingsByIdAsync(1)).ReturnsAsync(bookings);

            
            var result = await _controller.GetById(1);

            
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(bookings, okResult.Value);
        }

        [Fact]
        public async Task Add_ReturnsCreatedAtAction()
        {

            var forecast = new Booking { Id = 1, ServiceId = 1, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", Status = BookingStatus.Confirmed };


            var result = await _controller.Add(forecast);

            
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            Assert.Equal(nameof(_controller.GetById), createdAtActionResult.ActionName);
            Assert.Equal(forecast.Id, createdAtActionResult.RouteValues["id"]);
            Assert.Equal(forecast, createdAtActionResult.Value);
        }

        [Fact]
        public async Task Update_ReturnsBadRequest_WhenIdMismatch()
        {

            var forecast = new Booking { Id = 1, ServiceId = 1, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", Status = BookingStatus.Confirmed };


            var result = await _controller.Update(2, forecast);

            
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Update_ReturnsNoContent_WhenSuccessful()
        {

            var forecast = new Booking { Id = 1, ServiceId = 1, CustomerId = "9a54338d-49f5-420b-904e-a7d6b94ef8ed", Status = BookingStatus.Confirmed };

            
            var result = await _controller.Update(1, forecast);

            
            Assert.IsType<NoContentResult>(result);
        }

        [Fact]
        public async Task Delete_ReturnsNoContent_WhenSuccessful()
        {
            
            var result = await _controller.Delete(1);

            
            Assert.IsType<NoContentResult>(result);
        }
    }
}
