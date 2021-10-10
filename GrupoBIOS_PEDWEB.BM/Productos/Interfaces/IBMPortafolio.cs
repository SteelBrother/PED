using GrupoBIOS_PEDWEB.DT.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.BM.Productos.Interfaces
{
    public interface IBMPortafolio
    {
        Task<ActionResult<ICollection<Portafolio>>> ObtenerPortafolioPorCliente(int ClienteId, string SucursalId, int Compania);
    }
}
