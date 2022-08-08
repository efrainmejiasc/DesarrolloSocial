using Microsoft.AspNetCore.Mvc;

namespace DesarrolloSocialWeb.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContext;
        public AboutController(ILogger<HomeController> logger,IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
            _logger = logger;
        }

        public IActionResult RegistroGestor()
        {
            return View();
        }
    }
}
