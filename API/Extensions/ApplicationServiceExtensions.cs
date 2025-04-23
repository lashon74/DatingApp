using System;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions;

public static class ApplicationServiceExtensions //always need to be static so methods in class can be used without creating new instance of class
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
        services.AddDbContext<DataContext>(opt =>
         {
             opt.UseSqlite(config.GetConnectionString("DefaultConnection"));

         });
        services.AddCors();//needed to connect both projects 
        services.AddScoped<ITokenService, TokenService>(); //added once per client request common practice to use interface then a class that uses it

        return services;
    }
}
