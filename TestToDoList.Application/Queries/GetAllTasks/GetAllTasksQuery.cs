using MediatR;
using TestToDoList.Application.ViewModels;

namespace TestToDoList.Application.Queries.GetAllTasks;

public class GetAllTasksQuery : IRequest<List<TaskViewModel>>
{
	public string Query { get; private set; }

	public GetAllTasksQuery(string query)
	{
		Query = query;
	}
}