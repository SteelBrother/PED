using GrupoBIOS_PEDWEB.DT.DTOs;
using GrupoBIOS_PEDWEB.DT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion.Interfaces
{
    public interface ICargarCompanias_ViewModel
    {
        List<Compania> ListaCompanias { get; set; }
        Compania Compania { get; set; }
        Task<List<Compania>> CargarCompanias();

    }
}
