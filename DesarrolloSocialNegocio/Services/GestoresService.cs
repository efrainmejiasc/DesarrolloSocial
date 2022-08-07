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
    public  class GestoresService :IGestoresService
    {
        private readonly IGestoresRepository gestoresRepository;
        public GestoresService(IGestoresRepository _gestoresRerpository)
        {
            this.gestoresRepository = _gestoresRerpository;
        }

        public bool InsertGestor(Gestores model)
        {
           var resultado = false;
           model =  this.gestoresRepository.InsertGestor(model);
            if (model.Id > 0)
                resultado = true;

            return resultado;
        }

        public Gestores  GetGestor(string usermail, string password)
        {
            return this.gestoresRepository.GetGestor(usermail, password);
        }
    }
}
