using DataAccess;
using DataAccess.Implementations;
using DataAccess.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Services.Implementations;
using Services.Interfaces;

namespace Helpers
{
    public class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IResourceRepository, ResourceRepository>();
            services.AddTransient<IBookingRepository, BookingRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<IResourceService, ResourceService>();
        }
    }
}
