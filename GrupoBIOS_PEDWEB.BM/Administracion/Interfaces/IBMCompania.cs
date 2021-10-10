using GrupoBIOS_PEDWEB.DT.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.BM.Administracion.Interfaces
{
    public interface IBMCompania
    {
        Task<ActionResult<ICollection<Compania>>> ObtenerCompanias();
        Task<ActionResult<Compania>> ObtenerCompaniaPorId(int Id);
        Task<ActionResult<List<int>>> ActualizarCompañia(Compania Compañia);
        Task<ActionResult<List<string>>> GuardarCompañia(Compania Compañia);
       
    }
}
