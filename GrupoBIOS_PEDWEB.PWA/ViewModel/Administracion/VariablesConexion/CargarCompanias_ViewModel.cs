using GrupoBIOS_PEDWEB.DT.DTOs;
using GrupoBIOS_PEDWEB.DT.Entidades;
using GrupoBIOS_PEDWEB.PWA.Model.Administracion.VariablesConexion.Interfaces;
using GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion
{
    public class CargarCompanias_ViewModel : ICargarCompanias_ViewModel
    {
        private readonly ICargarCompanias_Model _CargarCompanias;
        public List<Compania> ListaCompanias { get; set; } = new List<Compania>();

        public Compania Compania { get; set; } = new Compania();
        public CargarCompanias_ViewModel(ICargarCompanias_Model CargarCompanias)
        {
            _CargarCompanias = CargarCompanias;
        }

        public async Task<List<Compania>> CargarCompanias()
        {
            try
            {
                ListaCompanias = await _CargarCompanias.CargarCompañias();
                return ListaCompanias;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
