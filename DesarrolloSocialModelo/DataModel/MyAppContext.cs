using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    public class MyAppContext :DbContext
    {
         public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options)
         {
         }

        public virtual DbSet<RespuestasDeFormulario> RespuestasDeFormulario { get; set; }
    }
}
