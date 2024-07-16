using Microsoft.EntityFrameworkCore;
using ServiceMarketplace.Data;
using ServiceMarketplace.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceMarketplace.Repository
{
    public interface IServiceMarketplaceRepository
    {
        Task<IEnumerable<WeatherForecast>> GetAllAsync();
        Task<WeatherForecast?> GetByIdAsync(int id);
        Task AddAsync(WeatherForecast forecast);
        Task UpdateAsync(WeatherForecast forecast);
        Task DeleteAsync(int id);
    }

    public class ServiceMarketplaceRepository : IServiceMarketplaceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceMarketplaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAllAsync()
        {
            return await _context.WeatherForecasts.ToListAsync();
        }

        public async Task<WeatherForecast> GetByIdAsync(int id)
        {
            return await _context.WeatherForecasts.FindAsync(id);
        }

        public async Task AddAsync(WeatherForecast entity)
        {
            await _context.WeatherForecasts.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(WeatherForecast entity)
        {
            _context.WeatherForecasts.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _context.WeatherForecasts.FindAsync(id);
            if (entity != null)
            {
                _context.WeatherForecasts.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
    }
}
