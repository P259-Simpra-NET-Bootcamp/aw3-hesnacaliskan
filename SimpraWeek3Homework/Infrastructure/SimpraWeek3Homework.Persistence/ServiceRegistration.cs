using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpraWeek3Homework.Application.Repositories.Categories;
using SimpraWeek3Homework.Application.Repositories.Products;
using SimpraWeek3Homework.Persistence.Contexts;
using SimpraWeek3Homework.Persistence.Repositories.Categories;
using SimpraWeek3Homework.Persistence.Repositories.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {            
            services.AddDbContext<SimpraWeek3HomeworkDbContext>(options => options.UseSqlServer(Configuration.ConnectionString), ServiceLifetime.Scoped);
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();           
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
