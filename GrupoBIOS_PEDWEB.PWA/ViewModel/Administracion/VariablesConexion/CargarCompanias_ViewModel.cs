using GrupoBIOS_PEDWEB.DT.DTOs;
using GrupoBIOS_PEDWEB.DT.Entidades;
using GrupoBIOS_PEDWEB.PWA.Model.Administracion.VariablesConexion.Interfaces;
using GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.VariablesConexion
{
    public class CargarCompanias_ViewModel : ICargarCompanias_ViewModel
    {
        private readonly ICargarCompanias_Model _CargarCompanias;
        private readonly ILogger<CargarCompanias_ViewModel> _logger;
        public List<Compania> ListaCompanias { get; set; } = new List<Compania>();

        public Compania Compania { get; set; } = new Compania();
        public CargarCompanias_ViewModel(ICargarCompanias_Model CargarCompanias, ILogger<CargarCompanias_ViewModel> logger)
        {
            _CargarCompanias = CargarCompanias;
            _logger = logger;

        }

        public async Task CargarCompanias()
        {
            try
            {
                ListaCompanias = await _CargarCompanias.CargarCompañias();   
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() != "WebAssembly.JSException" && ex.GetType().ToString() != "System.Net.Http.HttpRequestException" && ex.GetType().ToString() != "System.OperationCanceledException")
                {
                    _logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod().DeclaringType.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                }
            }
        }

        public async Task<Compania> CargarCompaniaPorId(int Id)
        {
            try
            {
                 Compania = await _CargarCompanias.CargarCompaniaPorId(Id);

                if (Compania != null)
                {
                    return Compania;
                }
                else
                {
                    return new Compania();
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() != "WebAssembly.JSException" && ex.GetType().ToString() != "System.Net.Http.HttpRequestException" && ex.GetType().ToString() != "System.OperationCanceledException")
                {
                    _logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod().DeclaringType.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                }
                return null;
            }
        }
    }
}
