using DesarrolloSocialModelo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialNegocio.Interfaces
{
    public interface IResponsabledeFamiliaService
    {
        bool InsertResponsabledeFamilia(ResponsabledeFamilia model);
        bool ExiteResponsabledeFamiliaRegistrada(string cedula);

    }
}
