using MediatR;

namespace TestToDoList.Application.Commands.DeleteTask;

public class DeleteTaskCommand : IRequest<Unit>
{
	public int Id { get; private set; }

	public DeleteTaskCommand(int id)
	{
		Id = id;
	}
}