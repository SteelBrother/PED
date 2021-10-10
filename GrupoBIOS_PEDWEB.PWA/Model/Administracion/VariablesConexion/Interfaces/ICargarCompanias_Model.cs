using GrupoBIOS_PEDWEB.DT.DTOs;
using GrupoBIOS_PEDWEB.DT.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Model.Administracion.VariablesConexion.Interfaces
{
    public interface ICargarCompanias_Model
    {
        Task<List<Compania>> CargarCompañias();
        Task<Compania> CargarCompaniaPorId(int Id);
    }
}
