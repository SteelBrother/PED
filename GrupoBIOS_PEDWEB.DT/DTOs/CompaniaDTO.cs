using System;
using Insight.Database;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupoBIOS_PEDWEB.DT.Entidades;

namespace GrupoBIOS_PEDWEB.DT.DTOs
{
    public class CompaniaDTO
    {
        [Column(SerializationMode = SerializationMode.Json)]
        public Compania Compania { get; set; }
    }
}
