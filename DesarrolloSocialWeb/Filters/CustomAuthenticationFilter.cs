using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DesarrolloSocialWeb.Filters
{
    public class CustomAuthenticationFilter:  Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.IsHttps)
                context.Result = new ForbidResult();
        }
    }
}
