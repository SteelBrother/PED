using GrupoBIOS_PEDWEB.DT.Entidades;
using Insight.Database;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GrupoBIOS_PEDWEB.DT.DTOs
{
    public class CompaniasDTO
    {
        [Column(SerializationMode = SerializationMode.Json)]
        public List<Compania> ListaCompanias { get; set; }
    }
}
