using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TestToDoList.API.Extensions;
using TestToDoList.Application.Commands.CreateTask;
using TestToDoList.Application.Filters;
using TestToDoList.Application.Validators;
using TestToDoList.Core.Repositories;
using TestToDoList.Infra.Persistence;
using TestToDoList.Infra.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDataBase(connectionString)
	.AddRepositories()
	.AddFluenteValidatorServices()
	.AddCustomFilters()
	.AddMediatRServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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