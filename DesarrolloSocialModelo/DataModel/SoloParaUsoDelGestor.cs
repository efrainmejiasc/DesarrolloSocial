using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    [Table("SoloParaUsoDelGestor")]

    public class SoloParaUsoDelGestor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR(100)")]
        public string NecesidadDelEncuestado { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string NombredelGestor { get; set; }


        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string NumerodeDocumento { get; set; }

        [Column(Order = 5, TypeName = "DATETIME")]
        public DateTime FechaNacimiento { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string Telefono { get; set; }
















    }
}
