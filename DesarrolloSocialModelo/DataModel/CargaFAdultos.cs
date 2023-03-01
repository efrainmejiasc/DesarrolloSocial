using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    [Table("CargaFAdultos")]

    public class CargaFAdultos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        public int CantidadAdultos { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string TienenDocumentoAdultos { get; set; }

      
        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string EstudiaAdultos { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string TrabajaAdultos { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string IngresoAdultos { get; set; }

        [Column(Order = 7, TypeName = "VARCHAR(50)")]
        public string ActividadCulturalAdultos { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string EmbarazosAdultos { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string EnfermedadDiscapacidadAdultos { get; set; }

        [Column(Order = 10, TypeName = "VARCHAR(100)")]
        public string TratamientoAdultos { get; set; }

        [Column(Order = 11, TypeName = "INT")]
        public int IDCargaFamiliar { get; set; }

    }
}
