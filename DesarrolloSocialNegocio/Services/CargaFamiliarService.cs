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
    public class CargaFamiliarService : ICargaFamiliarService
    {
        private readonly ICargaFamiliarRepository cargaFamiliarRepository;

        public CargaFamiliarService(ICargaFamiliarRepository _cargaFamiliarRepository)
        {
            cargaFamiliarRepository = _cargaFamiliarRepository;
        }

        public CargaFamiliar InsertCargaFamiliar(CargaFamiliar model)
        {
            var resultado = false;
            model = this.cargaFamiliarRepository.InsertCargaFamiliarRepository(model);
       

            return model;
        }
    }
}
