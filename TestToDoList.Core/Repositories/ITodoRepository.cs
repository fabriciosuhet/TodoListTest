using TestToDoList.Core.Entities;

namespace TestToDoList.Core.Repositories;

public interface ITodoRepository
{
	Task<List<TodoItem>> GetAllAsync();
	Task<TodoItem?> GetById(int id);
	Task AddTaskAsync(TodoItem todoItem);
	Task UpdateTaskAsync(int id, TodoItem todoItem);
	Task DeleteTaskAsync(int id);
	Task SaveAsync();
}