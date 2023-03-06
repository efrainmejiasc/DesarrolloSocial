using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class ResponsabledeFamiliaRepository : IResponsabledeFamiliaRepository
    {

        private readonly MyAppContext db;
        public ResponsabledeFamiliaRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public ResponsabledeFamilia InsertResponsabledeFamiliaRepository(ResponsabledeFamilia model)
        {
            this.db.ResponsabledeFamilia.Add(model);
            this.db.SaveChanges();

            return model;
        }

        public ResponsabledeFamilia ExiteResponsabledeFamiliaRegistrada(string cedula)
        {
            var responsableModel = this.db.ResponsabledeFamilia.Where(x => x.NumerodeDocumento == cedula).FirstOrDefault();
            return responsableModel;
        }
    }
}
