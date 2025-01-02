using MediatR;
using TestToDoList.Core.Repositories;

namespace TestToDoList.Application.Commands.DeleteTask;

public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, Unit>
{
	private readonly ITodoRepository _todoRepository;

	public DeleteTaskCommandHandler(ITodoRepository todoRepository)
	{
		_todoRepository = todoRepository;
	}

	public async Task<Unit> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
	{
		await _todoRepository.DeleteTaskAsync(request.Id);
		return Unit.Value;
	}
}