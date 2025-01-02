using TestToDoList.Application.Commands.CreateTask;

namespace TestToDoList.API.Extensions;

public static class MediatRExntensions
{
	public static IServiceCollection AddMediatRServices(this IServiceCollection services)
	{
		services.AddMediatR(cfg =>
			cfg.RegisterServicesFromAssembly(typeof(CreateTaskCommand).Assembly));
		return services;
	}
}