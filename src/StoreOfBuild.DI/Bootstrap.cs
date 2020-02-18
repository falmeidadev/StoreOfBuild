using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using StoreOfBuild.Data;
using StoreOfBuild.Domain;
using StoreOfBuild.Domain.Products;

namespace StoreOfBuild.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(conection));
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient(typeof(CategoryStorer));
            services.AddTransient(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
