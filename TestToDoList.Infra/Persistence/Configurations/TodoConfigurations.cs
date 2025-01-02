using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestToDoList.Core.Entities;

namespace TestToDoList.Infra.Persistence.Configurations;

public class TodoConfigurations : IEntityTypeConfiguration<TodoItem>
{
	public void Configure(EntityTypeBuilder<TodoItem> builder)
	{
		builder
			.HasKey(ti => ti.Id);

		builder.Property(ti => ti.Title)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(ti => ti.Description)
			.HasMaxLength(255);

		builder.Property(ti => ti.Status)
			.IsRequired();
	}
}