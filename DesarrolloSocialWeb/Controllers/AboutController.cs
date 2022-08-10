using DesarrolloSocialModelo.DataModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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


        public IActionResult CrearRegistroGestor(string gestorModelStr)
        {
            var gestorModel = JsonConvert.DeserializeObject<Gestores>(gestorModelStr);
            return View();
        }
    }
}
