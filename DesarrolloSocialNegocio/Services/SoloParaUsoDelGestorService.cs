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
    public class SoloParaUsoDelGestorService : ISoloParaUsoDelGestorService
    {
        private readonly ISoloParaUsoDelGestorRepository soloParaUsoDelGestorRepository;

        public SoloParaUsoDelGestorService(ISoloParaUsoDelGestorRepository _soloParaUsoDelGestorRepository)
        {
            soloParaUsoDelGestorRepository = _soloParaUsoDelGestorRepository;
        }

        public bool InsertSoloParaUsoDelGestor(SoloParaUsoDelGestor model)
        {
            var resultado = false;
            model = this.soloParaUsoDelGestorRepository.InsertSoloParaUsoDelGestorRepository(model);
            if (model.Id > 0)
                resultado = true;

            return resultado;
        }
    }
}
