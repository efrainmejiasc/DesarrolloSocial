using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{


    [Table("CargaFJefeDefamilia")]

    public class CargaFJefeDefamilia
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR(50)")]
        public string TienenDocumentoJefeDeFamilia { get; set; }

        [Column(Order = 3, TypeName = "INT")]
        public int CantidadJefeDeFamilia { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string EstudiaJefeDeFamilia { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string TrabajaJefeDeFamilia { get; set; }

        [Column(Order = 6, TypeName = "FLOAT")]
        public decimal IngresoJefeDeFamilia { get; set; }

        [Column(Order = 7, TypeName = "DATETIME")]
        public DateTime ActividadCulturalJefeDeFamilia { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string EmbarazosJefeDeFamilia { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string EnfermedadDiscapacidadJefeDeFamilia { get; set; }

        [Column(Order = 10, TypeName = "VARCHAR(250)")]
        public string TratamientoJefeDeFamilia { get; set; }

        [Column(Order = 11, TypeName = "INT")]
        public int IDCargaFamiliar { get; set; }

    }
}
