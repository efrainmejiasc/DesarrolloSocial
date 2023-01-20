using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using DesarrolloSocialModelo.Repositories;
using DesarrolloSocialNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialNegocio.Services
{
    public class DatosPrincipalesRGService : IDatosPrincipalesRGService
    {
        private readonly IDatosPrincipalesRGRepository datosPrincipalesRGRepository;

        public DatosPrincipalesRGService(IDatosPrincipalesRGRepository _datosPrincipalesRGRepository)
        {
            datosPrincipalesRGRepository = _datosPrincipalesRGRepository;
        }

        public bool InsertDatosPrincipalesRG(DatosPrincipalesRG model)
        {
            var resultado = false;
            model = this.datosPrincipalesRGRepository.InsertDatosPrincipalesRGRepository(model);
            if (model.Id > 0)
                resultado = true;

            return resultado;
        }
    }

}

