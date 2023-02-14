
using DesarrolloSocialModelo.DataModel;
using DesarrolloSocialModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class DatosPrincipalesRGRepository: IDatosPrincipalesRGRepository
    {
   
    private readonly MyAppContext db;
    public DatosPrincipalesRGRepository(MyAppContext _db)
    {
        this.db = _db;
    }

    public DatosPrincipalesRG InsertDatosPrincipalesRGRepository(DatosPrincipalesRG model)
    {
        this.db.DatosPrincipalesRG.Add(model);
        this.db.SaveChanges();

        return model;
    }
    }
}
