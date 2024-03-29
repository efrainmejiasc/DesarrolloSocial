﻿
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
using DesarrolloSocialNegocio.Services;

namespace DesarrolloSocialWeb.Controllers
{
    //[CustomAuthenticationFilter]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGestoresService _gestoresService;
        private readonly IDatosPrincipalesRGService _datosPrincipalesRGService;
        private readonly ICargaFamiliarService _cargaFamiliarService;
        private readonly IResponsabledeFamiliaService _responsabledeFamiliaService;
        private readonly IHttpContextAccessor _httpContext;
        private readonly Gestores usuarioGestor;
        private readonly ICargaFNiñosService _cargaFNiñosService;
        private readonly ICargaFJefeDefamiliaService _cargaFJefeDefamiliaService;
        private readonly ICargaFAdolescentesService _cargaFAdolescentesService;
        private readonly ICargaFAdultosService _cargaFAdultosService;
        private readonly ICargaFAdultosMayoresService _cargaFAdultosMayoresService;
        




        public HomeController(ILogger<HomeController> logger, IGestoresService gestoresService, IHttpContextAccessor httpContext,
                             IDatosPrincipalesRGService datosPrincipalesRGService, IResponsabledeFamiliaService responsabledeFamiliaService,
                             ICargaFamiliarService cargaFamiliarService, ICargaFJefeDefamiliaService cargaFJefeDefamiliaService, ICargaFNiñosService cargaFNiñosService, ICargaFAdultosService cargaFAdultosService, ICargaFAdultosMayoresService cargaFAdultosMayoresService,
                             ICargaFAdolescentesService cargaFAdolescentesService)


        {
            this._logger = logger;
            this._datosPrincipalesRGService = datosPrincipalesRGService;
            this._gestoresService = gestoresService;
            this._responsabledeFamiliaService = responsabledeFamiliaService;
            this._cargaFamiliarService = cargaFamiliarService;
            this._httpContext = httpContext;
            this._cargaFNiñosService = cargaFNiñosService;
            this._cargaFAdolescentesService = cargaFAdolescentesService;
            this._cargaFAdultosService = cargaFAdultosService;
            this._cargaFAdultosMayoresService = cargaFAdultosMayoresService;
            this._cargaFJefeDefamiliaService = cargaFJefeDefamiliaService;

            if (!string.IsNullOrEmpty(_httpContext.HttpContext.Session.GetString("GestorLogin")))
                this.usuarioGestor = JsonConvert.DeserializeObject<Gestores>(_httpContext.HttpContext.Session.GetString("GestorLogin"));
            _cargaFNiñosService = cargaFNiñosService;
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


        [HttpPost]
        public IActionResult CrearDatosPrincipalesRG(string DatosPrincipalesRG)
        {
           
            var respuesta = new RespuestaModel();
            respuesta.Estado = false;
            respuesta.Mensaje = "El campo no puede estar vacio";

            if (string.IsNullOrEmpty(DatosPrincipalesRG))
                return Json(respuesta);

            var datosmodel = JsonConvert.DeserializeObject<DatosPrincipalesRG>(DatosPrincipalesRG);
            datosmodel.IdGestor = this.usuarioGestor.Id;

            try
            {
                var resultado = this._datosPrincipalesRGService.InsertDatosPrincipalesRG(datosmodel);
                if (resultado)
                {
                    respuesta.Estado = true;
                    respuesta.Mensaje = "Transacción exitosa";
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
                Console.WriteLine(ex.Message);
            }

            return Json(respuesta);
        }


        [HttpPost]
        public IActionResult CrearResponsabledeFamilia(string ResponsabledeFamilia)
        {

            var respuesta = new RespuestaModel();
            respuesta.Estado = false;
            respuesta.Mensaje = "El campo no puede estar vacio";

            if (string.IsNullOrEmpty(ResponsabledeFamilia))
                return Json(respuesta);

            var datosmodel = JsonConvert.DeserializeObject<ResponsabledeFamilia>(ResponsabledeFamilia);

            try
            {
                var resultado = this._responsabledeFamiliaService.InsertResponsabledeFamilia(datosmodel);
                if (resultado)
                {
                    respuesta.Estado = true;
                    respuesta.Mensaje = "Transacción exitosa";
                }
            }
            catch (Exception ex)
            {
                respuesta.Mensaje = ex.Message;
                Console.WriteLine(ex.Message);
            }

            return Json(respuesta);
        }


        [HttpPost]
        public IActionResult CrearCargaFamiliar(string CargaFamiliar)
        {

            var respuesta = new RespuestaModel();
            respuesta.Estado = false;
            respuesta.Mensaje = "El campo no puede estar vacio";

            if (string.IsNullOrEmpty(CargaFamiliar))
                return Json(respuesta);

            var cargadefamilia = new CargaFamiliar();
            cargadefamilia = JsonConvert.DeserializeObject<CargaFamiliar>(CargaFamiliar);

            //var cedula = string.Empty;

            //var existeCedulaRegistrada = this._responsabledeFamiliaService.ExiteResponsabledeFamiliaRegistrada(cedula);
            //if (existeCedulaRegistrada)
            //{
            //    respuesta.Estado = false;
            //    respuesta.Mensaje = "El numero de documento ya esta registrado";
            //    return Json(respuesta);
            //}

            var CargaFJefeDefamilia = new CargaFJefeDefamilia();
            CargaFJefeDefamilia = JsonConvert.DeserializeObject<CargaFJefeDefamilia>(CargaFamiliar);

            var CargaFNiños = new CargaFNiños();
            CargaFNiños = JsonConvert.DeserializeObject<CargaFNiños>(CargaFamiliar);

            var CargaFAdolescentes = new CargaFAdolescentes();
            CargaFAdolescentes = JsonConvert.DeserializeObject<CargaFAdolescentes>(CargaFamiliar);

            var CargaFAdultos = new CargaFAdultos();
            CargaFAdultos = JsonConvert.DeserializeObject<CargaFAdultos>(CargaFamiliar);

            var CargaFAdultosMayores = new CargaFAdultosMayores();
            CargaFAdultosMayores = JsonConvert.DeserializeObject<CargaFAdultosMayores>(CargaFamiliar);

       
            var resultado = false;
            try
            {
                cargadefamilia = this._cargaFamiliarService.InsertCargaFamiliar(cargadefamilia);

                if (cargadefamilia.Id > 0)
                {
                    CargaFNiños.IDCargaFamiliar = cargadefamilia.Id;
                    CargaFNiños = this._cargaFNiñosService.InsertCargaFNiños(CargaFNiños);

                    CargaFAdolescentes.IDCargaFamiliar = cargadefamilia.Id;
                    CargaFAdolescentes = this._cargaFAdolescentesService.InsertCargaFAdolescentes(CargaFAdolescentes);

                    CargaFAdultos.IDCargaFamiliar = cargadefamilia.Id;
                    CargaFAdultos = this._cargaFAdultosService.InsertCargaFAdultos(CargaFAdultos);

                    CargaFAdultosMayores.IDCargaFamiliar = cargadefamilia.Id;
                    CargaFAdultosMayores = this._cargaFAdultosMayoresService.InsertCargaFAdultosMayores(CargaFAdultosMayores);

                    CargaFJefeDefamilia.IDCargaFamiliar = cargadefamilia.Id;
                    CargaFJefeDefamilia = this._cargaFJefeDefamiliaService.InsertCargaFJefeDefamilia(CargaFJefeDefamilia);
                }

                resultado = true;
                if (resultado)
                {
                    respuesta.Estado = true;
                    respuesta.Mensaje = "Transacción exitosa";
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