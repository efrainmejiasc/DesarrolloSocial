using Microsoft.AspNetCore.Mvc;

namespace DesarrolloSocialWeb.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IHttpContextAccessor _httpContext;
        public AboutController(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public IActionResult RegistroGestor()
        {
            return View();
        }
    }
}
