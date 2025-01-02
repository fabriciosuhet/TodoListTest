using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TestToDoList.Core.Entities;

namespace TestToDoList.Infra.Persistence;

public class TodoDbContext : DbContext
{
	public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options){}
	
	public DbSet<TodoItem> TodoItems { get; set; }
	

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
	}
}