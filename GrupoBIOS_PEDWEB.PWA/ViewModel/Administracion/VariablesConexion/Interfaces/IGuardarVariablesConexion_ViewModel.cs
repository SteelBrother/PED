using GrupoBIOS_PEDWEB.DT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion.Interfaces
{
    interface IGuardarVariablesConexion_ViewModel
    {
        Compania Compania { get; set; }

        Task GuardarCompaniaAsync(Compania compania);
        Task ActualizarCompaniaAsync(Compania compania);
    }
}
