using GrupoBIOS_PEDWEB.DT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Model.Administracion.VariablesConexion.Interfaces
{
    public interface IGuardarVariablesConexionModel
    {
        Task GuardarCompañia(Compania Compañia);
        Task ActualizarCompania(Compania Compañia);
    }
}
