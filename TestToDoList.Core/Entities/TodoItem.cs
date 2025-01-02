using TestToDoList.Core.Enums;

namespace TestToDoList.Core.Entities;

public class TodoItem
{
	public int Id { get; private set; }
	public string Title { get; private set; }
	public string Description { get; private set; }
	public TodoListStatusEnum Status { get; private set; }
	public DateTime CreatedAt { get; private set; }
	
	protected TodoItem(){}

	public TodoItem(string title, string description)
	{
		Title = title;
		Description = description;
		Status = TodoListStatusEnum.Pending;
		CreatedAt = DateTime.Now;
	}

	public void Start()
	{
		if (Status == TodoListStatusEnum.Pending)
		{
			Status = TodoListStatusEnum.InProgress;
		}
	}

	public void Finish()
	{
		if (Status == TodoListStatusEnum.InProgress)
		{
			Status = TodoListStatusEnum.Completed;
		}
	}

	public void Update(string title, string description, TodoListStatusEnum status)
	{
		Title = title;
		Description = description;
		Status = status;
	}
}