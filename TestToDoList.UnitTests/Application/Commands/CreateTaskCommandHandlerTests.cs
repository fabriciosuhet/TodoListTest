using Moq;
using TestToDoList.Application.Commands.CreateTask;
using TestToDoList.Core.Entities;
using TestToDoList.Core.Repositories;

namespace TestToDoList.UnitTests.Application.Commands;

public class CreateTaskCommandHandlerTests
{
	[Fact]
	public async Task CreateTaskCommnadHandler_Tests()
	{
		// Arrange 
		var taskRepositoryMock = new Mock<ITodoRepository>();
		var createTaskCommand = new CreateTaskCommand
		{
			Title = "Teste",
			Description = "Descricao teste para camada de testes com xUnit",
		};
		
		var createTaskCommandHandler = new CreateTaskCommandHandler(taskRepositoryMock.Object);
		
		// Act 
		var id = await createTaskCommandHandler.Handle(createTaskCommand, new CancellationToken());
		
		// Assert
		Assert.True(id >= 0);
		taskRepositoryMock.Verify(tr => tr.AddTaskAsync(It.IsAny<TodoItem>()), Times.Once);
	}
}