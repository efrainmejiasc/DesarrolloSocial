﻿using DesarrolloSocialModelo.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.Interfaces
{

    public interface IViviendaRepository
    {
        Vivienda InsertViviendaRepository(Vivienda model);
    }
}