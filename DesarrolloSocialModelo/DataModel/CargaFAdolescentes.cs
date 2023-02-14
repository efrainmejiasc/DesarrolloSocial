using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    [Table("CargaFAdolescentes")]

    public class CargaFAdolescentes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        public int CantidadAdolecente { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string TienenDocumentoAdolecente { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string EstudiaAdolecente { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string TrabajaAdolecente { get; set; }

        [Column(Order = 6, TypeName = "FLOAT")]
        public decimal IngresoAdolecente { get; set; }

        [Column(Order = 7, TypeName = "DATETIME")]
        public DateTime ActividadCulturalAdolecente { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string EmbarazosAdolecente { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string EnfermedadDiscapacidadAdolecente { get; set; }

        [Column(Order = 10, TypeName = "VARCHAR(100)")]
        public string TratamientoAdolecente { get; set; }

        [Column(Order = 11, TypeName = "INT")]
        public int IDCargaFamiliar { get; set; }

    }
}
