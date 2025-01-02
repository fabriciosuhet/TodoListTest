using TestToDoList.Core.Enums;

namespace TestToDoList.Application.ViewModels;

public class TaskViewModel
{
	public int Id { get; set; }
	public string Title { get; private set; }
	public string Description { get; private set; }
	public TodoListStatusEnum Status { get; private set; }
	public DateTime CreatedAt { get; private set; }

	public TaskViewModel(int id, string title, string description, TodoListStatusEnum status, DateTime createdAt)
	{
		Id = id;
		Title = title;
		Description = description;
		Status = status;
		CreatedAt = createdAt;
	}
}