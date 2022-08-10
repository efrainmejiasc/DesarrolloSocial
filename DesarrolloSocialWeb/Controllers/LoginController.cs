using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialNegocio.Interfaces;
using DesarrolloSocialWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DesarrolloSocialWeb.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGestoresService _gestoresService;
        private readonly IHttpContextAccessor _httpContext;
        private readonly Gestores usuarioGestor;

        public LoginController(ILogger<HomeController> logger, IGestoresService gestoresService, IHttpContextAccessor httpContext)
        {
            this._logger = logger;
            this._gestoresService = gestoresService;
            this._httpContext = httpContext;

            if (!string.IsNullOrEmpty(_httpContext.HttpContext.Session.GetString("GestorLogin")))
                this.usuarioGestor = JsonConvert.DeserializeObject<Gestores>(_httpContext.HttpContext.Session.GetString("GestorLogin"));
        }
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult LoginGestor(string userMail, string password)
        {
            var respuesta = new RespuestaModel();
            respuesta.Estado = false;
            respuesta.Mensaje = "No autorizado";
            if (string.IsNullOrEmpty(userMail) || string.IsNullOrEmpty(password))
                return Json(respuesta);

            var passwordEncriptado = DesarrolloSocialNegocio.Helpers.Helper.EnCodeBase64(userMail + password);

            try
            {
                var gestor = this._gestoresService.GetGestor(userMail, passwordEncriptado);
                if (gestor != null)
                {
                    respuesta.Estado = true;
                    respuesta.Mensaje = "Autorizado";
                    _httpContext.HttpContext.Session.SetString("GestorLogin", JsonConvert.SerializeObject(gestor));
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
                Console.WriteLine(ex.Message);
            }

            return Json(respuesta);
        }
    }
}
