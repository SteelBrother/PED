using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.DT.Entidades
{
    public class Compania
    {

        [System.Text.Json.Serialization.JsonIgnore]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdSiesa { get; set; }
        public string NombreDB { get; set; }

    }
}
