using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{

    [Table("DatosPrincipalesRG")]
    public class DatosPrincipalesRG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "DATETIME")]
        public DateTime FechaRegistro { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR(100)")]
        public string Pais { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR(100)")]
        public string Estado { get; set; }
      
        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string Ciudad { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string Municipio { get; set; }

    
        [Column(Order = 7, TypeName = "VARCHAR(50)")]
        public string CodigoPostal { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string Parroquia { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(100)")]
        public string Urbanizacion { get; set; }

        [Column(Order = 10, TypeName = "VARCHAR(100)")]
        public String Avenida { get; set; }

        [Column(Order = 11, TypeName = "VARCHAR (50)")]
        public string EdifioCasa { get; set; }

        [Column(Order = 12, TypeName = "VARCHAR(50)")]
        public string Piso { get; set; }

        [Column(Order = 13, TypeName = "VARCHAR(50)")]
        public string Numerodecasa { get; set; }

        [Column(Order = 14, TypeName = "VARCHAR(50)")]
        public string PuntodeReferencia { get; set; }

        [Column(Order = 15, TypeName = "varchar(50)")]
        public string Telefono { get; set; }

        [Column(Order = 16, TypeName = "VARCHAR(50)")]
        public string TelefonoAlternativo { get; set; }

        [Column(Order = 17, TypeName = "VARCHAR(50)")]
        public string Correo { get; set; }
    }
}
