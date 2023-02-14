using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class CargaFamiliarRepository : ICargaFamiliarRepository
    {

        private readonly MyAppContext db;
        public CargaFamiliarRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public CargaFamiliar InsertCargaFamiliarRepository(CargaFamiliar model)
        {
            this.db.CargaFamiliar.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}
