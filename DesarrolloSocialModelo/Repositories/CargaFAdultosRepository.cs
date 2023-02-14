using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{

    public class CargaFAdultosRepository : ICargaFAdultosRepository
    {

        private readonly MyAppContext db;
        public CargaFAdultosRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public CargaFAdultos InsertCargaFAdultosRepository(CargaFAdultos model)
        {
            this.db.CargaFAdultos.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}
