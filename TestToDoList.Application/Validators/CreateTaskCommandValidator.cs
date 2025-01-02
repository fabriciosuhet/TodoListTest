using FluentValidation;
using TestToDoList.Application.Commands.CreateTask;

namespace TestToDoList.Application.Validators;

public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
{
	public CreateTaskCommandValidator()
	{
		RuleFor(t => t.Title)
			.NotEmpty()
			.WithMessage("O título não pode ser vázio.");

		RuleFor(t => t.Title)
			.Length(100)
			.WithMessage("O título não pode ter mais de 100 caracteres.");


		RuleFor(t => t.Description)
			.Length(255)
			.NotNull()
			.NotEmpty()
			.WithMessage("A descrição não pode ter mais de 255 caracteres");
		
	}
}