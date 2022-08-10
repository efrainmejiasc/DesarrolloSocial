using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialNegocio.Interfaces;
using DesarrolloSocialWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DesarrolloSocialWeb.Controllers
{
    public class AboutController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContext;
        private readonly IGestoresService _gestoresService;

        public AboutController(ILogger<HomeController> logger,IHttpContextAccessor httpContext, IGestoresService gestoresService)
        {
            this._httpContext = httpContext;
            this._logger = logger;
            this._gestoresService = gestoresService;
        }

        public IActionResult RegistroGestor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CrearRegistroGestor(string gestorModelStr)
        {
            var gestorModel = JsonConvert.DeserializeObject<Gestores>(gestorModelStr);

            var respuesta = new RespuestaModel();
            respuesta.Estado = false;
            respuesta.Mensaje = "Error al crear gestor";

            if (string.IsNullOrEmpty(gestorModelStr))
                return Json(respuesta);

            var passwordEncriptado = DesarrolloSocialNegocio.Helpers.Helper.EnCodeBase64(gestorModel.Email + gestorModel.Password);
            gestorModel.Password = passwordEncriptado;
            gestorModel.IdEstado =1;
            gestorModel.IdRol = 2;

            try
            {
                var resultado = this._gestoresService.InsertGestor(gestorModel);
                if (resultado)
                {
                    respuesta.Estado = true;
                    respuesta.Mensaje = "Gestor creado correctamente";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Json(respuesta);
        }
    }
}
