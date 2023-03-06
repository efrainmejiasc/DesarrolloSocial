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

        public CargaFAdultosMayores InsertCargaFAdultosMayores(CargaFAdultosMayores model)
        {
          
            model = this.CargaFAdultosMayoresRepository.InsertCargaFAdultosMayoresRepository(model);
            
             

            return model;
        }
    }

}

