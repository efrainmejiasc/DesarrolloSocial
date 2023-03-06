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
    public class ResponsabledeFamiliaService : IResponsabledeFamiliaService
    {
        private readonly IResponsabledeFamiliaRepository responsabledeFamiliaRepository;

        public ResponsabledeFamiliaService(IResponsabledeFamiliaRepository _responsabledeFamiliaRepository)
        {
            responsabledeFamiliaRepository = _responsabledeFamiliaRepository;
        }

        public bool InsertResponsabledeFamilia(ResponsabledeFamilia model)
        {
            var resultado = false;
            model = this.responsabledeFamiliaRepository.InsertResponsabledeFamiliaRepository(model);
            if (model.Id > 0)
                resultado = true;

            return resultado;
        }

        public bool ExiteResponsabledeFamiliaRegistrada(string cedula)
        {
            var modelo = this.responsabledeFamiliaRepository.ExiteResponsabledeFamiliaRegistrada(cedula);
            if (modelo != null)
                return true;

            return false;
        }
    }
}
