using GrupoBIOS_PEDWEB.DT.Entidades;
using GrupoBIOS_PEDWEB.PWA.Model.Administracion.VariablesConexion.Interfaces;
using GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion
{
    public class GuardarVariablesConexion_ViewModel : IGuardarVariablesConexion_ViewModel
    {
        private readonly IGuardarVariablesConexionModel _GuardarVariablesConexionModel;
        public Compania Compania { get; set; } = new Compania();

        public GuardarVariablesConexion_ViewModel(IGuardarVariablesConexionModel GuardarVariablesConexionModel)
        {
            _GuardarVariablesConexionModel = GuardarVariablesConexionModel;
        }

        public async Task GuardarCompaniaAsync(Compania compania)
        {
            await _GuardarVariablesConexionModel.GuardarCompañia(compania);
        }

        public async Task ActualizarCompaniaAsync(Compania compania)
        {
            await _GuardarVariablesConexionModel.ActualizarCompania(compania);
        }
    }
}
