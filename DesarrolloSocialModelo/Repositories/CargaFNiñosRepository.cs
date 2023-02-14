using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{

    public class CargaFNiñosRepository : ICargaFNiñosRepository
    {

        private readonly MyAppContext db;
        public CargaFNiñosRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public CargaFNiños InsertCargaFNiñosRepository(CargaFNiños model)
        {
            this.db.CargaFNiños.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}
