using FluentValidation;
using TestToDoList.Application.Commands.UpdateTask;

namespace TestToDoList.Application.Validators;

public class UpdateTaskCommandValidator : AbstractValidator<UpdateTaskCommand>
{
	public UpdateTaskCommandValidator()
	{
		RuleFor(t => t.Title)
			.NotEmpty()
			.NotNull()
			.WithMessage("O título é obrigatório");
		
		RuleFor(t => t.Title)
			.MaximumLength(100)
			.WithMessage("O tamanho máximo do título é de 100 caracteres");
		
		RuleFor(t => t.Description)
			.MaximumLength(255)
			.NotEmpty()
			.NotNull()
			.WithMessage("O tamanho máximo da descrição é de 255 caracteres");
	}
}