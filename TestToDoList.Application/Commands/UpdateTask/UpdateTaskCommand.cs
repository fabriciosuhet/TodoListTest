using MediatR;
using TestToDoList.Core.Enums;

namespace TestToDoList.Application.Commands.UpdateTask;

public class UpdateTaskCommand : IRequest<Unit>
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public TodoListStatusEnum Status { get; set; }
}