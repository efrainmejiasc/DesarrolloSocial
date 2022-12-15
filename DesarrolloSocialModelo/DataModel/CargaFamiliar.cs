using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    [Table("CargaFamiliar")]

    public class CargaFamiliar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR(100)")]
        public string CantidadDepersonasBajosuCargo { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string NiñosEstudian { get; set; }

       


    }
}
