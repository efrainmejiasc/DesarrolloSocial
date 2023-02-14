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
    public class CargaFJefeDefamiliaService : ICargaFJefeDefamiliaService
  
    {
        private readonly ICargaFJefeDefamiliaRepository CargaFJefeDefamiliaRepository;

        public CargaFJefeDefamiliaService(ICargaFJefeDefamiliaRepository _CargaFJefeDefamiliaRepository)
        {
            CargaFJefeDefamiliaRepository = _CargaFJefeDefamiliaRepository;
        }

        public CargaFJefeDefamilia InsertCargaFJefeDefamilia (CargaFJefeDefamilia model)
        {
         
            model = this.CargaFJefeDefamiliaRepository.InsertCargaFJefeDefamiliaRepository(model);


            return model;
        }
    }
}
