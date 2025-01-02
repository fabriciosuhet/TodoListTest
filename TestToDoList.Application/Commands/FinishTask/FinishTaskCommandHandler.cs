using MediatR;
using TestToDoList.Core.Repositories;

namespace TestToDoList.Application.Commands.FinishTask;

public class FinishTaskCommandHandler : IRequestHandler<FinishTaskCommand, Unit>
{
	private readonly ITodoRepository _todoRepository;

	public FinishTaskCommandHandler(ITodoRepository todoRepository)
	{
		_todoRepository = todoRepository;
	}

	public async Task<Unit> Handle(FinishTaskCommand request, CancellationToken cancellationToken)
	{
		var task = await _todoRepository.GetById(request.Id);
		task?.Finish();
		await _todoRepository.SaveAsync();
		return Unit.Value;

	}
}