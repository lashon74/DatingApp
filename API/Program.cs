using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));

});
builder.Services.AddCors();//needed to connect both projects 
builder.Services.AddScoped <ITokenService, TokenService>(); //added once per client request common practice to use interface then a class that uses it 

var app = builder.Build();

// Configure the HTTP request pipeline.
//needed to add middleware so project can reach these endpoints
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200", "https://localhost:4200"));

app.MapControllers();

app.Run();
