using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ReservationSystem.WebApi.ViewModels;

namespace ReservationSystem.WebApi.Filters
{
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ModelState.IsValid == false)
            {
                var messages = new List<string>();
                var errors = context.ModelState.Values.Select(e => e.Errors);

                foreach (var error in errors)
                    foreach (var @object in error)
                        messages.Add(@object.ErrorMessage);

                context.Result = new BadRequestObjectResult(new BadRequestResponse(messages));
            }
        }
    }

    public sealed class BadRequestResponse : ResponseBase
    {
        public BadRequestResponse(IEnumerable<string> errors) : base(errors) { }
    }
}
