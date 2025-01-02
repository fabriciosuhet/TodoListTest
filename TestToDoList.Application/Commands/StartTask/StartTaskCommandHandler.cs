using MediatR;
using TestToDoList.Core.Repositories;

namespace TestToDoList.Application.Commands.StartTask;

public class StartTaskCommandHandler : IRequestHandler<StartTaskCommand, Unit>
{
	private readonly ITodoRepository _todoRepository;

	public StartTaskCommandHandler(ITodoRepository todoRepository)
	{
		_todoRepository = todoRepository;
	}

	public async Task<Unit> Handle(StartTaskCommand request, CancellationToken cancellationToken)
	{
		var task = await _todoRepository.GetById(request.Id);
		if (task == null) throw new KeyNotFoundException("Tarefa não encontrada.");
		task.Start();

		await _todoRepository.SaveAsync();
		return Unit.Value;
	}
}