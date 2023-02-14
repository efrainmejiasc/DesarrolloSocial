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
    public class CargaFAdultosService : ICargaFAdultosService

    {
        private readonly ICargaFAdultosRepository CargaFAdultosRepository;

        public CargaFAdultosService(ICargaFAdultosRepository _CargaFAdultosRepository)
        {
            CargaFAdultosRepository = _CargaFAdultosRepository;
        }

        public CargaFAdultos InsertCargaFAdultos(CargaFAdultos model)
        {

            model = this.CargaFAdultosRepository.InsertCargaFAdultosRepository(model);


            return model;
        }
    }
}
