using MediatR;

namespace TestToDoList.Application.Commands.StartTask;

public class StartTaskCommand : IRequest<Unit>
{
	public int Id { get; private set; }

	public StartTaskCommand(int id)
	{
		Id = id;
	}
}