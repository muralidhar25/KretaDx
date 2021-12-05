

global using KretaDx.BLL.Service;
global using KretaDx.DAL.Repository.Interfaces;
global using KretaDx.DAL.Repository.Services;
global using Microsoft.AspNetCore.Mvc;
global using KretaDx.BLL.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Host.ConfigureDefaults(args);

builder.WebHost.ConfigureServices(services =>
services.AddTransient<IEmployeeService, EmployeeService>()
.AddTransient<IEmployeeRepository, EmployeeRepository>()); 

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
