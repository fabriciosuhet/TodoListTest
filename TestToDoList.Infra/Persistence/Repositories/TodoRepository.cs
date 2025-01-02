using Microsoft.EntityFrameworkCore;
using TestToDoList.Core.Entities;
using TestToDoList.Core.Repositories;

namespace TestToDoList.Infra.Persistence.Repositories;

public class TodoRepository : ITodoRepository
{
	private readonly TodoDbContext _dbContext;

	public TodoRepository(TodoDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public async Task<List<TodoItem>> GetAllAsync()
	{
		return await _dbContext.TodoItems.ToListAsync();
	}

	public async Task<TodoItem?> GetById(int id)
	{
		return await _dbContext.TodoItems.FindAsync(id);
	}

	public async Task AddTaskAsync(TodoItem todoItem)
	{
		await _dbContext.TodoItems.AddAsync(todoItem);
		await _dbContext.SaveChangesAsync();
	}

	public async Task UpdateTaskAsync(int id, TodoItem todoItem)
	{
		var taskExists = await _dbContext.TodoItems.FindAsync(id);
		if (taskExists == null)
		{
			throw new KeyNotFoundException($"A tarefa com {id} não foi encontrada");
		}
		
		todoItem.Update(taskExists.Title, taskExists.Description, taskExists.Status);
		await _dbContext.SaveChangesAsync();
	}

	public async Task DeleteTaskAsync(int id)
	{
		var taskExists = await _dbContext.TodoItems.SingleOrDefaultAsync(t => t.Id == id);
		if (taskExists != null)
		{
			_dbContext.Remove(taskExists);
		}
		await _dbContext.SaveChangesAsync();
	}

	public async Task SaveAsync()
	{
		await _dbContext.SaveChangesAsync();
	}
}