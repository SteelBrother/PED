using GrupoBIOS_PEDWEB.DT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Model.Administracion.Productos.Interfaces
{
    public interface IConsultarPortafolio_Model
    {
        Task<List<Portafolio>> ConsultarPortafolioPorCliente(int ClienteId, string SucursalId, int CompaniaId);
    }
}
