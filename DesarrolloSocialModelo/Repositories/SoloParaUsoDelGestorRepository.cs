using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class SoloParaUsoDelGestorRepository : ISoloParaUsoDelGestorRepository
    {

        private readonly MyAppContext db;
        public SoloParaUsoDelGestorRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public SoloParaUsoDelGestor InsertSoloParaUsoDelGestorRepository(SoloParaUsoDelGestor model)
        {
            this.db.SoloParaUsoDelGestor.Add(model);
            this.db.SaveChanges();

            return model;
        }
    }
}
