using Microsoft.EntityFrameworkCore;
using TrialDataAPI.Data;
using TrialDataAPI.Services.Interfaces;
using TrialDataAPI.Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var conn = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<MainContext>(options => options.UseSqlServer(conn));

builder.Services.AddScoped<IEmployee, EmployeeRepository>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
