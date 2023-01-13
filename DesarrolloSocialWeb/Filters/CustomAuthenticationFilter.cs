using DesarrolloSocialWeb.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DesarrolloSocialWeb.Filters
{
    public class CustomAuthenticationFilter: ActionFilterAttribute //Attribute, IAuthorizationFilter
    {
        private readonly IHttpContextAccessor httpContext;

        public CustomAuthenticationFilter()
        {
            this.httpContext = new HttpContextAccessor();
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                if (string.IsNullOrEmpty(this.httpContext.HttpContext.Session.GetString("GestorLogin")))
                {
                    if (filterContext.Controller is LoginController == false || filterContext.Controller is GFormController == false)
                    {
                        filterContext.HttpContext.Response.Redirect("/Login/Index");
                    }

                }
            }
            catch
            {
                filterContext.Result = new RedirectResult("~/Login/Index");
            }
        }
    }
}
