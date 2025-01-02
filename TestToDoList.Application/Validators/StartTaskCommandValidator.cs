using FluentValidation;
using TestToDoList.Application.Commands.StartTask;

namespace TestToDoList.Application.Validators;

public class StartTaskCommandValidator : AbstractValidator<StartTaskCommand>
{
	public StartTaskCommandValidator()
	{
		RuleFor(t => t.Id)
			.NotEmpty()
			.NotNull()
			.WithMessage("O id é obrigatório");
	}
}