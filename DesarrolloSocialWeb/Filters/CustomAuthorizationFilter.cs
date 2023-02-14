using Microsoft.AspNetCore.Mvc.Filters;



namespace DesarrolloSocialWeb.Filters
{
    public class CustomAuthorizationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Executed before execution of an action method
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Executed after execution of an action method
        }
    }
}
