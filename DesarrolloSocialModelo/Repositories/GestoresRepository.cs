﻿using DesarrolloSocialModelo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Repositories
{
    public class GestoresRepository : IGestoresRerpository
    {
        private readonly MyAppContext db;
        public GestoresRepository(MyAppContext _db)
        {
            this.db = _db;
        }

        public Gestores InsertGestor (Gestores model)
        {
            this.db.Gestores.Add(model);
            this.db.SaveChanges();

            return model;
        }

    }
}
