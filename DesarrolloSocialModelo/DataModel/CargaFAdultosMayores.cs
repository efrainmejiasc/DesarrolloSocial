using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{

    [Table("CargaFAdultosMayores")]

    public class CargaFAdultosMayores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        public int CantidadAdultosMayores { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string TienenDocumentoAdultosMayores { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string EstudiaAdultosMayores { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string TrabajaAdultosMayores { get; set; }

        [Column(Order = 6, TypeName = "FLOAT")]
        public decimal IngresoAdultosMayores { get; set; }

        [Column(Order = 7, TypeName = "VARCHAR(50)")]
        public string ActividadCulturalAdultosMayores { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string EmbarazosAdultosMayores { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string EnfermedadDiscapacidadAdultosMayores { get; set; }

        [Column(Order = 10, TypeName = "VARCHAR(100)")]
        public string TratamientoAdultosMayores { get; set; }

        [Column(Order = 11, TypeName = "INT")]
        public int IDCargaFamiliar { get; set; }


    }
}
