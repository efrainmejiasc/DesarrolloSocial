using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class CargaFAdolescentesRepository : ICargaFAdolescentesRepository
    {

        private readonly MyAppContext db;
        public CargaFAdolescentesRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public CargaFAdolescentes InsertCargaFAdolescentesRepository(CargaFAdolescentes model)
        {
            this.db.CargaFAdolescentes.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}
