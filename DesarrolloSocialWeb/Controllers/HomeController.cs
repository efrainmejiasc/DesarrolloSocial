using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DesarrolloSocialWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        [HttpGet]
        public IActionResult LoginGestor(string userMail, string password)
        {
            if (string.IsNullOrEmpty(userMail) || string.IsNullOrEmpty(password))
                return Json("");

            return Json("");
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





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}