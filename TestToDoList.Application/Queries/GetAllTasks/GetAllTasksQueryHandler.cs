using MediatR;
using TestToDoList.Application.ViewModels;
using TestToDoList.Core.Repositories;

namespace TestToDoList.Application.Queries.GetAllTasks;

public class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQuery, List<TaskViewModel>>
{
	private readonly ITodoRepository _todoRepository;

	public GetAllTasksQueryHandler(ITodoRepository todoRepository)
	{
		_todoRepository = todoRepository;
	}

	public async Task<List<TaskViewModel>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
	{
		var tasks = await _todoRepository.GetAllAsync();
		if (!string.IsNullOrWhiteSpace(request.Query))
		{
			tasks = tasks
				.Where(t =>
					(t.Title.Contains(request.Query, StringComparison.OrdinalIgnoreCase)) ||
					(t.Description.Contains(request.Query, StringComparison.OrdinalIgnoreCase))
				)
				.ToList();
		}
		
		var taskViewModels = tasks.Select(t => 
			new TaskViewModel(t.Id, t.Title, t.Description, t.Status, t.CreatedAt))
			.ToList();
		return taskViewModels;
	}
}