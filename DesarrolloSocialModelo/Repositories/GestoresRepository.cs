using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class GestoresRepository : IGestoresRepository
    {
        private readonly MyAppContext db;
        public GestoresRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public Gestores InsertGestor (Gestores model)
        {
            this.db.Gestores.Add(model);
            this.db.SaveChanges();

            return model;
        }

        public Gestores GetGestor(string usermail , string password)
        {
            var gestor = this.db.Gestores.Where(x => x.Email == usermail && x.Password == password).FirstOrDefault();
            return gestor;
        }

    }
}
