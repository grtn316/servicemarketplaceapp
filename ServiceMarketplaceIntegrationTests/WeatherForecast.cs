using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;
using ServiceMarketplace;
using Newtonsoft.Json;
using System.Text;
using System.Collections.Generic;
using ServiceMarketplace.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.Extensions.DependencyInjection;
using ServiceMarketplace.Data;

namespace ServiceMarketplace.Tests
{


public class WeatherForecastIntegrationTests : IClassFixture<CustomWebApplicationFactory<Program>>, IAsyncLifetime
    {
    private readonly HttpClient _client;
    private readonly CustomWebApplicationFactory<Program> _factory;

    public WeatherForecastIntegrationTests(CustomWebApplicationFactory<Program> factory)
    {
        _factory = factory;
        _client = factory.CreateClient();
    }

    public async Task InitializeAsync()
    {
        using (var scope = _factory.Services.CreateScope())
        {
            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

            // Clear the database
            _factory.ClearDatabase(db);

            // Seed the database with data for testing
            SeedDatabase(db);
        }

        await Task.CompletedTask;
    }

    public async Task DisposeAsync()
    {
        await Task.CompletedTask;
    }

    private void SeedDatabase(ApplicationDbContext dbContext)
    {
        // Add test data to the database.
        dbContext.WeatherForecasts.AddRange(new List<WeatherForecast>
    {
        new WeatherForecast { Id = 1, Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 25, Summary = "Mild" },
        new WeatherForecast { Id = 2, Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 30, Summary = "Hot" }
    });
        dbContext.SaveChanges();
    }

        [Fact]
    public async Task Get_ReturnsAllWeatherForecasts()
    {
            
        var response = await _client.GetAsync("/api/WeatherForecast");

        response.EnsureSuccessStatusCode(); // Status Code 200-299
        var stringResponse = await response.Content.ReadAsStringAsync();
        var forecasts = JsonConvert.DeserializeObject<List<WeatherForecast>>(stringResponse);
        Assert.Equal(2, forecasts.Count);
    }

    [Fact]
    public async Task GetById_ReturnsWeatherForecast_WhenForecastExists()
    {

        var response = await _client.GetAsync("/api/WeatherForecast/1");

        response.EnsureSuccessStatusCode(); // Status Code 200-299
        var stringResponse = await response.Content.ReadAsStringAsync();
        var forecast = JsonConvert.DeserializeObject<WeatherForecast>(stringResponse);
        Assert.Equal(25, forecast.TemperatureC);
    }

    [Fact]
    public async Task GetById_ReturnsNotFound_WhenForecastDoesNotExist()
    {

        var response = await _client.GetAsync("/api/WeatherForecast/999");

        Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Add_AddsWeatherForecast()
    {
      
        var newForecast = new WeatherForecast { Id = 3, Date = DateOnly.FromDateTime(DateTime.Now), TemperatureC = 22, Summary = "Cool" };
        var content = new StringContent(JsonConvert.SerializeObject(newForecast), Encoding.UTF8, "application/json");

        var response = await _client.PostAsync("/api/WeatherForecast", content);

        response.EnsureSuccessStatusCode(); // Status Code 201
        var stringResponse = await response.Content.ReadAsStringAsync();
        var addedForecast = JsonConvert.DeserializeObject<WeatherForecast>(stringResponse);
        Assert.Equal(22, addedForecast.TemperatureC);
    }
}

}