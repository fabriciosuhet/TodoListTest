using MediatR;

namespace TestToDoList.Application.Commands.CreateTask;

public class CreateTaskCommand : IRequest<int>
{
	public string Title { get; set; }
	public string Description { get; set; }

}