using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class CargaFAdultosMayoresRepository : ICargaFAdultosMayoresRepository
    {

        private readonly MyAppContext db;
        public CargaFAdultosMayoresRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public CargaFAdultosMayores InsertCargaFAdultosMayoresRepository(CargaFAdultosMayores model)
        {
            this.db.CargaFAdultosMayores.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}
