using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    [Table("Gestores")]
    public  class Gestores
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
        public string Email { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR(50)")]
        public string Telefono  { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR(50)")]
        public string Pais { get; set; }

        [Column(Order = 7, TypeName = "VARCHAR(50)")]
        public string Estado { get; set; }

        [Column(Order = 8, TypeName = "VARCHAR(50)")]
        public string Ciudad{ get; set; }

        [Column(Order = 9, TypeName = "VARCHAR(100)")]
        public string Password { get; set; }

        [Column(Order = 10, TypeName = "INT")]
        public int IdEstado { get; set; }

        [Column(Order = 11, TypeName = "DATETIME")]
        public DateTime FechaNacimiento { get; set; }

        [Column(Order = 12, TypeName = "VARCHAR(50)")]
        public string TipoDocumento { get; set; }

        [Column(Order = 13, TypeName = "VARCHAR(50)")]
        public string NumeroDocumento{ get; set; }

        [Column(Order = 14, TypeName = "INT")]
        public int IdRol { get; set; }

    }
}
