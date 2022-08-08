
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using DesarrolloSocialNegocio.Interfaces;
using DesarrolloSocialWeb.Models;
using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialWeb.Filters;
using System.Web.Http.Filters;

namespace DesarrolloSocialWeb.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGestoresService _gestoresService;
        private readonly IHttpContextAccessor _httpContext;
        private readonly Gestores usuarioGestor;

        public HomeController(ILogger<HomeController> logger, IGestoresService gestoresService, IHttpContextAccessor httpContext)
        {
            this._logger = logger;
            this._gestoresService = gestoresService;
            this._httpContext = httpContext;

            if (!string.IsNullOrEmpty(_httpContext.HttpContext.Session.GetString("GestorLogin")))
                this.usuarioGestor = JsonConvert.DeserializeObject<Gestores>(_httpContext.HttpContext.Session.GetString("GestorLogin"));
        }

        public IActionResult Index()
        {
            // return RedirectToAction("Index","Login");
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult CorredorHumanitario()
        {
            return View();
        }


        public IActionResult ResponsabledeFamilia()
        {
            return View();
        }

        public IActionResult CargaFamiliar()

        {
            return View();
        }

        public IActionResult Vivienda()
        {
            return View();
        }
        public IActionResult SoloParaUsodelGestorylaFundacion()
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
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return Json(respuesta);
        }

        [HttpGet]
        public async Task<IActionResult> GetPaisesAsync()
        {
            var respuesta = string.Empty;
            var paises = new PaisesModel();

            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://restcountries.com/v3.1/all");
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://countriesnow.space/api/v0.1/countries");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    paises = JsonConvert.DeserializeObject<PaisesModel>(respuesta);
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return Json(paises);
        }


        [HttpGet]
        public async Task<IActionResult> GetCiudadesPaisAsync(int id)
        {
            var respuesta = string.Empty;
            var paises = new PaisesModel();
            var ciudades = new List<string>();
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, "https://countriesnow.space/api/v0.1/countries");
                var response = await client.SendAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    respuesta = await response.Content.ReadAsStringAsync();
                    paises = JsonConvert.DeserializeObject<PaisesModel>(respuesta);
                    ciudades = paises.data[id].cities.ToList();
                }
            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }

            return Json(ciudades);
        }

        [HttpGet]
        public IActionResult GetUsuarioGestorLogger()
        {
            return Json(this.usuarioGestor);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}