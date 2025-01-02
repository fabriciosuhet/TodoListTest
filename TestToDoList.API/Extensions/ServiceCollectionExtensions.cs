using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using TestToDoList.Application.Filters;
using TestToDoList.Application.Validators;
using TestToDoList.Core.Repositories;
using TestToDoList.Infra.Persistence;
using TestToDoList.Infra.Persistence.Repositories;

namespace TestToDoList.API.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddDataBase(this IServiceCollection services, string connectionString)
	{
		services.AddDbContext<TodoDbContext>(opt =>
			opt.UseSqlite(connectionString));
		return services;
	}

	public static IServiceCollection AddRepositories(this IServiceCollection services)
	{
		services.AddScoped<ITodoRepository, TodoRepository>();
		return services;
	}

	public static IServiceCollection AddFluenteValidatorServices(this IServiceCollection services)
	{
		services.AddFluentValidationAutoValidation()
			.AddFluentValidationClientsideAdapters()
			.AddValidatorsFromAssemblyContaining<CreateTaskCommandValidator>();
		return services;
	}

	public static IServiceCollection AddCustomFilters(this IServiceCollection services)
	{
		services.AddControllers(opt =>
			opt.Filters.Add(typeof(ValidationFilter)));
		return services;
	}
}