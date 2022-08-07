using DesarrolloSocialModelo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialNegocio.Interfaces
{
    public interface IGestoresService
    {
        bool InsertGestor(Gestores model);
        Gestores GetGestor(string usermail, string password);
    }
}
