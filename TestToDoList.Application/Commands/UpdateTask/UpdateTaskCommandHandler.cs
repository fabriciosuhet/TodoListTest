using MediatR;
using TestToDoList.Core.Repositories;

namespace TestToDoList.Application.Commands.UpdateTask;

public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand, Unit>
{
	private readonly ITodoRepository _todoRepository;

	public UpdateTaskCommandHandler(ITodoRepository todoRepository)
	{
		_todoRepository = todoRepository;
	}

	public async Task<Unit> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
	{
		var task = await _todoRepository.GetById(request.Id);
		task?.Update(request.Title, request.Description, request.Status);
		
		await _todoRepository.SaveAsync();
		return Unit.Value;
	}
}