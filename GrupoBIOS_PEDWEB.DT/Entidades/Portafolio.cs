using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.DT.Entidades
{
    public class Portafolio
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public int Id { get; set; }
        [Display(Name = "Referencia")]
        public string f120_referencia { get; set; }
        [Display(Name = "Descripcion")]
        public string f120_descripcion { get; set; }
        [Display(Name = "Linea")]
        public string linea { get; set; }
        [Display(Name = "Sublinea")]
        public string sublinea { get; set; }
        [Display(Name = "Medicado")]
        public string medicado { get; set; }
    }
}
