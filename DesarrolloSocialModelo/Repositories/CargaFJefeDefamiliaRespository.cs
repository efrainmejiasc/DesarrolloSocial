using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class CargaFJefeDefamiliaRepository : ICargaFJefeDefamiliaRepository
    {

        private readonly MyAppContext db;
        public CargaFJefeDefamiliaRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public CargaFJefeDefamilia InsertCargaFJefeDefamiliaRepository(CargaFJefeDefamilia model)
        {
            this.db.CargaFJefeDefamilia.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}