using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    [Table("RespuestasDeFormulario")]
    public class RespuestasDeFormulario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "DATETIME")] 
        public DateTime MarcaTemporal { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(50)")]
        public string NummeroIdentificacion { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR(100)")]
        public string Nombre { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(100)")]
        public string Apellido { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string CorreoElectronioco { get; set; }

        [Column(Order = 7, TypeName = "VARCHAR(10)")]
        public string? TienesLasVacunasContraElCovid19 { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(10)")]
        public string? PadecesDeAlgunaEnfermedadActualmente { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(10)")]
        public string? TienesAlgunaEnfermedadOCondicionHederitaria { get; set; }


        [Column(Order = 10, TypeName = "VARCHAR(50)")]
        public string? ConQueFRecuenciaTeHacesUnChequeoMedico { get; set; }

    }
}
