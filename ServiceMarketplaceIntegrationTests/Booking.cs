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


public class BookingIntegrationTests : IClassFixture<CustomWebApplicationFactory<Program>>, IAsyncLifetime
    {
    private readonly HttpClient _client;
    private readonly CustomWebApplicationFactory<Program> _factory;

    public BookingIntegrationTests(CustomWebApplicationFactory<Program> factory)
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
        dbContext.Bookings.AddRange(new List<Booking>
    {
        new Booking { Id = 1, StartTime = DateTime.Now.AddDays(1), EndTime = DateTime.Now.AddDays(1).AddHours(1), ServiceId = 1, CustomerID = "b01873ec-546c-4813-b93b-e7bef86a4de4", BusinessID = 1, Cost = 100, Status = BookingStatus.Confirmed },
        new Booking { Id = 2, StartTime = DateTime.Now.AddDays(2), EndTime = DateTime.Now.AddDays(2).AddHours(1), ServiceId = 2, CustomerID = "06874549-8158-4144-891c-1a33141904bd", BusinessID = 2, Cost = 150, Status = BookingStatus.Canceled }
    });
        dbContext.SaveChanges();
    }

        [Fact]
    public async Task Get_ReturnsAllBookings()
    {
            
        var response = await _client.GetAsync("/api/Booking");

        response.EnsureSuccessStatusCode(); // Status Code 200-299
        var stringResponse = await response.Content.ReadAsStringAsync();
        var booking = JsonConvert.DeserializeObject<List<Booking>>(stringResponse);
        Assert.Equal(2, booking.Count);
    }

    [Fact]
    public async Task GetById_ReturnsBooking_WhenBookingExists()
    {

        var response = await _client.GetAsync("/api/Booking/1");

        response.EnsureSuccessStatusCode(); // Status Code 200-299
        var stringResponse = await response.Content.ReadAsStringAsync();
        var booking = JsonConvert.DeserializeObject<Booking>(stringResponse);
        Assert.Equal(100, booking.Cost);
    }

    [Fact]
    public async Task GetById_ReturnsNotFound_WhenBookingDoesNotExist()
    {

        var response = await _client.GetAsync("/api/Booking/999");

        Assert.Equal(System.Net.HttpStatusCode.NotFound, response.StatusCode);
    }

    [Fact]
    public async Task Add_AddsBooking()
    {

        var newBooking = new Booking { Id = 3, StartTime = DateTime.Now.AddDays(3), EndTime = DateTime.Now.AddDays(3).AddHours(1), ServiceId = 3, CustomerID = "b01873ec-546c-4813-b93b-e7bef86a4de4", BusinessID = 3, Cost = 200, Status = BookingStatus.Complete };
        var content = new StringContent(JsonConvert.SerializeObject(newBooking), Encoding.UTF8, "application/json");

        var response = await _client.PostAsync("/api/Booking", content);

        response.EnsureSuccessStatusCode(); // Status Code 201
        var stringResponse = await response.Content.ReadAsStringAsync();
        var addedBooking = JsonConvert.DeserializeObject<Booking>(stringResponse);
        Assert.Equal(200, addedBooking.Cost);
    }
}

}