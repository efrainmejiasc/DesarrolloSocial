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
    public class CargaFNiñosService : ICargaFNiñosService

    {
        private readonly ICargaFNiñosRepository cargaFNiñosRepository;

        public CargaFNiñosService(ICargaFNiñosRepository _cargaFNiñosRepository)
        {
            cargaFNiñosRepository = _cargaFNiñosRepository;
        }

        public CargaFNiños InsertCargaFNiños(CargaFNiños model)
        {

            model = this.cargaFNiñosRepository.InsertCargaFNiñosRepository(model);

            return model;
        }
    }
}
