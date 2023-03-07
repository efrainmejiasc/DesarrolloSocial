using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{

    [Table("Vivienda")]

  public class Vivienda
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR(100)")]
        public string TipodeVivienda{ get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string CondiciondelaVivienda { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string RequerimientodelaVivienda { get; set; }

        [Column(Order = 5, TypeName = "DATETIME")]
        public DateTime TEnenciadelaVivienda { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string Agua { get; set; }
        [Column(Order = 7, TypeName = "VARCHAR(50)")]
        public string Electricidad { get; set; }
        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string AguasServidas { get; set; }
        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string Telefoníafija { get; set; }
        [Column(Order = 10, TypeName = "VARCHAR(50)")]
        public string AseoUrbanoRecolectordeBasura { get; set; }
       [Column(Order = 11, TypeName = "VARCHAR(50)")]

        public string AseguraqueTodosLosDatosIngresadosSonCorrectos { get; set; }












    }
}
