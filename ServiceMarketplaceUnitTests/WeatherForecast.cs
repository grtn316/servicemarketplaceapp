using Microsoft.AspNetCore.Mvc;
using Moq;
using ServiceMarketplace.Controllers;
using ServiceMarketplace.Entities;
using ServiceMarketplace.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ServiceMarketplace.Tests
{
    public class WeatherForecastControllerTests
    {
        private readonly Mock<IServiceMarketplaceRepository> _mockRepo;
        private readonly WeatherForecastController _controller;

        public WeatherForecastControllerTests()
        {
            _mockRepo = new Mock<IServiceMarketplaceRepository>();
            _controller = new WeatherForecastController(_mockRepo.Object);
        }

        [Fact]
        public async Task Get_ReturnsAllWeatherForecasts()
        {
            
            var forecasts = new List<WeatherForecast>
            {
                new WeatherForecast { Id = 1, TemperatureC = 25 },
                new WeatherForecast { Id = 2, TemperatureC = 30 }
            };
            _mockRepo.Setup(repo => repo.GetAllAsync()).ReturnsAsync(forecasts);

            
            var result = await _controller.Get();

            
            Assert.Equal(forecasts, result);
        }

        [Fact]
        public async Task GetById_ReturnsNotFound_WhenForecastDoesNotExist()
        {
            
            _mockRepo.Setup(repo => repo.GetByIdAsync(It.IsAny<int>())).ReturnsAsync((WeatherForecast?)null);

            
            var result = await _controller.GetById(1);

            
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetById_ReturnsForecast_WhenForecastExists()
        {
            
            var forecast = new WeatherForecast { Id = 1, TemperatureC = 25 };
            _mockRepo.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(forecast);

            
            var result = await _controller.GetById(1);

            
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(forecast, okResult.Value);
        }

        [Fact]
        public async Task Add_ReturnsCreatedAtAction()
        {
            
            var forecast = new WeatherForecast { Id = 1, TemperatureC = 25 };

            
            var result = await _controller.Add(forecast);

            
            var createdAtActionResult = Assert.IsType<CreatedAtActionResult>(result);
            Assert.Equal(nameof(_controller.GetById), createdAtActionResult.ActionName);
            Assert.Equal(forecast.Id, createdAtActionResult.RouteValues["id"]);
            Assert.Equal(forecast, createdAtActionResult.Value);
        }

        [Fact]
        public async Task Update_ReturnsBadRequest_WhenIdMismatch()
        {
            
            var forecast = new WeatherForecast { Id = 1, TemperatureC = 25 };

            
            var result = await _controller.Update(2, forecast);

            
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Update_ReturnsNoContent_WhenSuccessful()
        {
            
            var forecast = new WeatherForecast { Id = 1, TemperatureC = 25 };

            
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
