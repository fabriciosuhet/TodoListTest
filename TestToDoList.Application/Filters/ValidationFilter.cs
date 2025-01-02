using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TestToDoList.Application.Filters;

public class ValidationFilter : IActionFilter
{
	public void OnActionExecuting(ActionExecutingContext context)
	{
		if (!context.ModelState.IsValid)
		{
			var messages = context.ModelState
				.SelectMany(message => message.Value.Errors)
				.Select(e => e.ErrorMessage)
				.ToList();

			context.Result = new BadRequestObjectResult(messages);
		}
	}

	public void OnActionExecuted(ActionExecutedContext context)
	{
		
	}
}