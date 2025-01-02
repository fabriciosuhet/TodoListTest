using MediatR;
using Microsoft.AspNetCore.Mvc;
using TestToDoList.Application.Commands.CreateTask;
using TestToDoList.Application.Commands.DeleteTask;
using TestToDoList.Application.Commands.FinishTask;
using TestToDoList.Application.Commands.StartTask;
using TestToDoList.Application.Commands.UpdateTask;
using TestToDoList.Application.Queries.GetAllTasks;

namespace TestToDoList.API.Controllers;

[ApiController]
[Route("tasks")]
public class TodoItemsController : ControllerBase
{
	private readonly IMediator _mediator;

	public TodoItemsController(IMediator mediator)
	{
		_mediator = mediator;
	}

	[HttpGet]
	public async Task<IActionResult> GetAll(string? query)
	{
		var getAllTasksQuery = new GetAllTasksQuery(query);
		var tasks = await _mediator.Send(getAllTasksQuery);
		if (tasks is null) return NotFound();
		return Ok(tasks);
		
	}

	[HttpPost]
	public async Task<IActionResult> Post([FromBody] CreateTaskCommand command)
	{
		var id = await _mediator.Send(command);
		return CreatedAtAction(null, new { id }, command);
	}

	[HttpPut("{id}")]
	public async Task<IActionResult> Put(int id, [FromBody] UpdateTaskCommand command)
	{
		await _mediator.Send(command);
		return NoContent();
	}

	[HttpDelete("{id}")]
	public async Task<IActionResult> Delete(int id)
	{
		var command = new DeleteTaskCommand(id);
		await _mediator.Send(command);
		return Ok("Tarefa excluida com sucesso.");
	}

	[HttpPut("{id}/start")]
	public async Task<IActionResult> Start(int id)
	{
		var command = new StartTaskCommand(id);
		await _mediator.Send(command);
		return NoContent();
	}
	
	[HttpPut("{id}/finish")]
	public async Task<IActionResult> Finish(int id)
	{
		var command = new FinishTaskCommand(id);
		await _mediator.Send(command);
		return NoContent();
	}
}