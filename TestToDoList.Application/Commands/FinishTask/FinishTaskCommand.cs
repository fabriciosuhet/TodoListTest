using MediatR;

namespace TestToDoList.Application.Commands.FinishTask;

public class FinishTaskCommand : IRequest<Unit>
{
	public int Id { get; private set; }

	public FinishTaskCommand(int id)
	{
		Id = id;
	}
}