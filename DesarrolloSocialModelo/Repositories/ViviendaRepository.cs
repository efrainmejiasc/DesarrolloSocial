using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class ViviendaRepository : IViviendaRepository
    {

        private readonly MyAppContext db;
        public ViviendaRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public Vivienda InsertViviendaRepository(Vivienda model)
        {
            this.db.Vivienda.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}