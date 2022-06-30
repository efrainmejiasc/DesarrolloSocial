using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesarrolloSocialModelo.DataModel
{
    public class RespuestasDeFormulario
    {
        public DateTime MarcaTemporal { get; set; }

        public string DireccionDeCorreoElectronico { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CorreoElectronioco { get; set; }
        public string? TienesLasVacunasContraElCovid19 { get; set; }   
       public string? PadecesDeAlgunaEnfermedadActualmente { get; set; }
        public string? TienesAlgunaEnfermedadOCondicionHederitaria { get; set; }    
        public string? ConQueFRecuenciaTeHacesUnChequeoMedico { get; set; }



    }
}
