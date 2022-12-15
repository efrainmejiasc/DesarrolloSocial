using DesarrolloSocialModelo.DataModel;
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
        public virtual DbSet<Gestores> Gestores { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<DatosPrincipalesRG> DatosPrincipalesRG { get; set; }
        public virtual DbSet<ResponsabledeFamilia> ResponsabledeFamilia { get; set; }
        public virtual DbSet<CargaFamiliar> CargaFamiliar { get; set; }


        public virtual DbSet<CargaFJefeDefamilia> CargaFJefedeFamilia { get; set; }
        public virtual DbSet<CargaFAdultos> CargaFAdultos { get; set; }

       public virtual DbSet<CargaFAdultosMayores> CargaFAdultosMayores{ get; set; }

       public virtual DbSet<CargaFNiños> CargaFNiños { get; set; }

       public virtual DbSet<CargaFAdolescentes> CargaFAdolescentes { get; set; }

      public virtual DbSet<SoloParaUsoDelGestor> SoloParaUsoDelGestor { get; set; }

      public virtual DbSet<Vivienda> Vivienda { get; set; }
    }

}
