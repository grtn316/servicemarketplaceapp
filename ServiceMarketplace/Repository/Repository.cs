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

        //Business
        Task<IEnumerable<Business>> GetAllBusinessesAsync();
        Task<Business> GetBusinessesByIdAsync(int id);
        Task AddBusinessesAsync(Business entity);
        Task UpdateBusinessesAsync(Business entity);
        Task DeleteBusinessesAsync(int id);

        //BusinessUser
        Task<IEnumerable<BusinessUser>> GetAllBusinessUsersAsync();
        Task<BusinessUser> GetBusinessUsersByIdAsync(int id);
        Task AddBusinessUsersAsync(BusinessUser entity);
        Task UpdateBusinessUsersAsync(BusinessUser entity);
        Task DeleteBusinessUsersAsync(int id);

        //CustomerUser
        Task<IEnumerable<CustomerUser>> GetAllCustomerUsersAsync();
        Task<CustomerUser> GetCustomerUsersByIdAsync(int id);
        Task AddCustomerUsersAsync(CustomerUser entity);
        Task UpdateCustomerUsersAsync(CustomerUser entity);
        Task DeleteCustomerUsersAsync(int id);

        //Inquiry
        Task<IEnumerable<Inquiry>> GetAllInquiriesAsync();
        Task<Inquiry> GetInquiriesByIdAsync(int id);
        Task AddInquiriesAsync(Inquiry entity);
        Task UpdateInquiriesAsync(Inquiry entity);
        Task DeleteInquiriesAsync(int id);

        
        //Review
        Task<IEnumerable<Review>> GetAllReviewsAsync();
        Task<Review> GetReviewsByIdAsync(int id);
        Task AddReviewsAsync(Review entity);
        Task UpdateReviewsAsync(Review entity);
        Task DeleteReviewsAsync(int id);

        //ServiceAvailability
        Task<IEnumerable<ServiceAvailability>> GetAllServiceAvailabilityAsync();
        Task<ServiceAvailability> GetServiceAvailabilityByIdAsync(int id);
        Task AddServiceAvailabilityAsync(ServiceAvailability entity);
        Task UpdateServiceAvailabilityAsync(ServiceAvailability entity);
        Task DeleteServiceAvailabilityAsync(int id);

        //Service
        Task<IEnumerable<Service>> GetAllServicesAsync();
        Task<Service> GetServicesByIdAsync(int id);
        Task AddServicesAsync(Service entity);
        Task UpdateServicesAsync(Service entity);
        Task DeleteServicesAsync(int id);


    }

    public class ServiceMarketplaceRepository : IServiceMarketplaceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceMarketplaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        //Business
        public async Task<IEnumerable<Business>> GetAllBusinessesAsync()
        {
            return await _context.Businesses.ToListAsync();
        }

        public async Task<Business> GetBusinessesByIdAsync(int id)
        {
            return await _context.Businesses.FindAsync(id);
        }

        public async Task AddBusinessesAsync(Business entity)
        {
            await _context.Businesses.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBusinessesAsync(Business entity)
        {
            _context.Businesses.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBusinessesAsync(int id)
        {
            var entity = await _context.Businesses.FindAsync(id);
            if (entity != null)
            {
                _context.Businesses.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        //BusinessUser
        public async Task<IEnumerable<BusinessUser>> GetAllBusinessUsersAsync()
        {
            return await _context.BusinessUsers.ToListAsync();
        }

        public async Task<BusinessUser> GetBusinessUsersByIdAsync(int id)
        {
            return await _context.BusinessUsers.FindAsync(id);
        }

        public async Task AddBusinessUsersAsync(BusinessUser entity)
        {
            await _context.BusinessUsers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBusinessUsersAsync(BusinessUser entity)
        {
            _context.BusinessUsers.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBusinessUsersAsync(int id)
        {
            var entity = await _context.BusinessUsers.FindAsync(id);
            if (entity != null)
            {
                _context.BusinessUsers.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        //CustomerUser
        public async Task<IEnumerable<CustomerUser>> GetAllCustomerUsersAsync()
        {
            return await _context.CustomerUsers.ToListAsync();
        }

        public async Task<CustomerUser> GetCustomerUsersByIdAsync(int id)
        {
            return await _context.CustomerUsers.FindAsync(id);
        }

        public async Task AddCustomerUsersAsync(CustomerUser entity)
        {
            await _context.CustomerUsers.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomerUsersAsync(CustomerUser entity)
        {
            _context.CustomerUsers.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomerUsersAsync(int id)
        {
            var entity = await _context.CustomerUsers.FindAsync(id);
            if (entity != null)
            {
                _context.CustomerUsers.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        //Inquiry
        public async Task<IEnumerable<Inquiry>> GetAllInquiriesAsync()

        {
            return await _context.Inquiries.ToListAsync();
        }

        public async Task<Inquiry> GetInquiriesByIdAsync(int id)
        {
            return await _context.Inquiries.FindAsync(id);
        }

        public async Task AddInquiriesAsync(Inquiry entity)
        {
            await _context.Inquiries.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateInquiriesAsync(Inquiry entity)
        {
            _context.Inquiries.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInquiriesAsync(int id)
        {
            var entity = await _context.Inquiries.FindAsync(id);
            if (entity != null)
            {
                _context.Inquiries.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        //Review
        public async Task<IEnumerable<Review>> GetAllReviewsAsync()
        {
            return await _context.Reviews.ToListAsync();
        }

        public async Task<Review> GetReviewsByIdAsync(int id)
        {
            return await _context.Reviews.FindAsync(id);
        }

        public async Task AddReviewsAsync(Review entity)
        {
            await _context.Reviews.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReviewsAsync(Review entity)
        {
            _context.Reviews.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReviewsAsync(int id)
        {
            var entity = await _context.Reviews.FindAsync(id);
            if (entity != null)
            {
                _context.Reviews.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        //ServiceAvailability
        public async Task<IEnumerable<ServiceAvailability>> GetAllServiceAvailabilityAsync()
        {
            
            return await _context.ServiceAvailability.ToListAsync();
        }

        public async Task<ServiceAvailability> GetServiceAvailabilityByIdAsync(int id)
        {
            return await _context.ServiceAvailability.FindAsync(id);
        }

        public async Task AddServiceAvailabilityAsync(ServiceAvailability entity)
        {
            await _context.ServiceAvailability.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateServiceAvailabilityAsync(ServiceAvailability entity)
        {
            _context.ServiceAvailability.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteServiceAvailabilityAsync(int id)
        {
            var entity = await _context.ServiceAvailability.FindAsync(id);
            if (entity != null)
            {
                _context.ServiceAvailability.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        //Service
        public async Task<IEnumerable<Service>> GetAllServicesAsync()
        {
            return await _context.Services.ToListAsync();
        }

        public async Task<Service> GetServicesByIdAsync(int id)
        {
            return await _context.Services.FindAsync(id);
        }

        public async Task AddServicesAsync(Service entity)
        {
            await _context.Services.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateServicesAsync(Service entity)
        {
            _context.Services.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteServicesAsync(int id)
        {
            var entity = await _context.Services.FindAsync(id);
            if (entity != null)
            {
                _context.Services.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }


        //WeatherForecast
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
