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
    public class CargaFAdultosMayoresService : ICargaFAdultosMayoresService
    {
        private readonly ICargaFAdultosMayoresRepository CargaFAdultosMayoresRepository;

        public CargaFAdultosMayoresService(ICargaFAdultosMayoresRepository _CargaFAdultosMayoresRepository)
        {
            CargaFAdultosMayoresRepository = _CargaFAdultosMayoresRepository;
        }

        public bool InsertCargaFAdultosMayores(CargaFAdultosMayores model)
        {
            var resultado = false;
            model = this.CargaFAdultosMayoresRepository.InsertCargaFAdultosMayoresRepository(model);
            if (model.Id > 0)
                resultado = true;

            return resultado;
        }
    }

}

