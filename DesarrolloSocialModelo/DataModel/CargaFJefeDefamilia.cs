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

        [Column(Order = 2, TypeName = "INT")]
        public int CantidadPersonasAcargo { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string TienenDocumento { get; set; }


        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string Estudia { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string Trabaja { get; set; }

        [Column(Order = 6, TypeName = "FLOAT")]
        public decimal Ingreso { get; set; }

        [Column(Order = 7, TypeName = "DATETIME")]
        public DateTime ActividadCultural { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string Embarazos { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string EnfermedadDiscapacidad { get; set; }

        [Column(Order = 10, TypeName = "VARCHAR(100)")]
        public string Tratamiento { get; set; }

        [Column(Order = 11, TypeName = "INT")]
        public int IDCargaFamiliar { get; set; }





    }
}
