using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{

    [Table("CargaFNiños")]

    public class CargaFNiños
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        public int CantidadNiños { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string TienenDocumentoNiños { get; set; }

       
        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string EstudiaNiños { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string TrabajaNiños { get; set; }

        [Column(Order = 6, TypeName = "FLOAT")]
        public decimal IngresoNiños { get; set; }

        [Column(Order = 7, TypeName = "DATETIME")]
        public DateTime ActividadCulturalNiños { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string EmbarazosNiños { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string EnfermedadDiscapacidadNiños { get; set; }

        [Column(Order = 10, TypeName = "VARCHAR(100)")]
        public string TratamientoNiños { get; set; }


        [Column(Order = 11, TypeName = "INT")]
        public int IDCargaFamiliar { get; set; }

    }
}
