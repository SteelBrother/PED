using GrupoBIOS_PEDWEB.DT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.Productos.Interfaces
{
    public interface IConsultarPortafolio_ViewModel
    {
        Portafolio portafolio { get; set; }
        public List<Portafolio> ListaPortafolios { get; set; }
        Task CargarPortafolioPorCliente(int ClienteId, string SucursalId, int CompaniaId);
    }
}
