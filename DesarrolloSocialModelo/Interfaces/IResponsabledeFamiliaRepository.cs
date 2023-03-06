using DesarrolloSocialModelo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Interfaces
{
   public interface IResponsabledeFamiliaRepository
    {
        ResponsabledeFamilia ExiteResponsabledeFamiliaRegistrada(string cedula);
        ResponsabledeFamilia InsertResponsabledeFamiliaRepository(ResponsabledeFamilia model);
    }
}

