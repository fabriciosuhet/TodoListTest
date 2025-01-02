using FluentValidation;
using TestToDoList.Application.Commands.FinishTask;

namespace TestToDoList.Application.Validators;

public class FinishTaskCommandValidator : AbstractValidator<FinishTaskCommand>
{
	public FinishTaskCommandValidator()
	{
		RuleFor(t => t.Id)
			.NotNull()
			.NotEmpty()
			.WithMessage("O id é obrigatório.");
	}
}