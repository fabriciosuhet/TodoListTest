using MediatR;
using TestToDoList.Core.Entities;
using TestToDoList.Core.Repositories;

namespace TestToDoList.Application.Commands.CreateTask;

public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
{
	private readonly ITodoRepository _todoRepository;

	public CreateTaskCommandHandler(ITodoRepository todoRepository)
	{
		_todoRepository = todoRepository;
	}

	public async Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
	{
		var task = new TodoItem(request.Title, request.Description);
		
		await _todoRepository.AddTaskAsync(task);
		return task.Id;
	}
}