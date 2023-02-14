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
    public class ViviendaService : IViviendaService
    {
        private readonly IViviendaRepository viviendaRepository;

        public ViviendaService(IViviendaRepository _viviendaRepository)
        {
            viviendaRepository = _viviendaRepository;
        }

        public bool InsertVivienda(Vivienda model)
        {
            var resultado = false;
            model = this.viviendaRepository.InsertViviendaRepository(model);
            if (model.Id > 0)
                resultado = true;

            return resultado;
        }
    }
}
