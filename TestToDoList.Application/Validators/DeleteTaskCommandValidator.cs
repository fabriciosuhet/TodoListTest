using FluentValidation;
using TestToDoList.Application.Commands.DeleteTask;

namespace TestToDoList.Application.Validators;

public class DeleteTaskCommandValidator : AbstractValidator<DeleteTaskCommand>
{
	public DeleteTaskCommandValidator()
	{
		RuleFor(t => t.Id)
			.NotEmpty()
			.NotNull()
			.WithMessage("O id é obrigatório.");
	}
	
}