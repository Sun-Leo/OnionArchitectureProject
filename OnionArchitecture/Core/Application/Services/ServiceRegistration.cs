using Application.Mapping;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
            services.AddAutoMapper(opt =>
            {
                opt.AddProfiles(new List<Profile>
                {
                    new AboutProfiles(),
                    new OurDishesProfiles(),
                    new ProductProfiles(),
                    new CategoriProfiles(),
                    new DinnerMenuProfiles(),
                    new LunchMenuProfiles(),
                    new BreakfastMenuProfiles()

                });
            });
        }
    }
}
