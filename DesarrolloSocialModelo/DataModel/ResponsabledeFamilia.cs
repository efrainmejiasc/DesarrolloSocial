using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    [Table("Responsabledefamilia")]
    public class ResponsabledeFamilia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR(100)")]
        public string Nombres { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string Apellidos { get; set; }

     
        [Column(Order = 4, TypeName = "VARCHAR(50)")]
        public string Nacionalidad { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string Documento { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string NumerodeDocumento { get; set; }


        [Column(Order = 7, TypeName = "VARCHAR(50)")]
        public string lugardeNacimiento { get; set; }


        [Column(Order = 8, TypeName = "DATETIME")]
        public DateTime FechaNacimiento { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(50)")]
        public string Edad { get; set; }

        [Column(Order = 10,TypeName = "VARCHAR(50)")]
        public string Sexo { get; set; }

        [Column(Order = 11, TypeName = "VARCHAR(100)")]
        public string EstadoCivil { get; set; }

        [Column(Order = 12, TypeName = "INT")]
        public int NiveldeInstruccion { get; set; }


        [Column(Order = 13, TypeName = "VARCHAR(50)")]
        public string Profesion { get; set; }

        [Column(Order = 14, TypeName = "VARCHAR(50)")]
        public string Habilidades { get; set; }

        [Column(Order = 15, TypeName = "INT")]
        public int Trabaja { get; set; }

        [Column(Order = 16, TypeName = "INT")]
        public int CondicionLaboral { get; set; }

        [Column(Order = 17, TypeName = "VARCHAR(50)")]
        public string NivelInstruccion { get; set; }

        [Column(Order = 18, TypeName = "VARCHAR(50)")]
        public string TipodeNegocio { get; set; }

        [Column(Order = 19, TypeName = "VARCHAR(50)")]
        public string MediodeTransporte { get; set; }

        [Column(Order = 20,TypeName = "VARCHAR(50)")]
        public string TieneHijos { get; set; }

        [Column(Order = 21, TypeName = "INT")]
        public int NumerodeHijos { get; set; }

        [Column(Order = 22, TypeName = "VARCHAR(50)")]
        public string TieneDiscapacidad { get; set; }

        [Column(Order = 23, TypeName = "INT")]
        public int TieneTratamiento { get; set; }

        [Column(Order = 22, TypeName = "VARCHAR(50)")]
        public string TipodeDiscapacidad { get; set; }

        [Column(Order = 24, TypeName = "INT")]
        public int PadeceEnfermedad { get; set; }

        [Column(Order = 25, TypeName = "VARCHAR(50)")]
        public string TipoEnfermedad { get; set; }

        [Column(Order = 26, TypeName = "VARCHAR(50)")]
        public string Tienetratamiento { get; set; }

        [Column(Order = 27, TypeName = "VARCHAR(50)")]
        public string TipodeTratamiento { get; set; }



    }
}
