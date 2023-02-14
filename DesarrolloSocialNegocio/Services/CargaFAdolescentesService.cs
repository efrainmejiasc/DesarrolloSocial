using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using DesarrolloSocialNegocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialNegocio.Services
{
    public class CargaFAdolescentesService : ICargaFAdolescentesService
    {
        private readonly ICargaFAdolescentesRepository CargaFAdolescentesRepository;

        public CargaFAdolescentesService(ICargaFAdolescentesRepository _CargaFAdolescentesRepository)
        {
            CargaFAdolescentesRepository = _CargaFAdolescentesRepository;
        }

        public CargaFAdolescentes InsertCargaFAdolescentes(CargaFAdolescentes model)
        {
            var resultado = false;
            model = this.CargaFAdolescentesRepository.InsertCargaFAdolescentesRepository(model);


            return model;
        }
    }
}
