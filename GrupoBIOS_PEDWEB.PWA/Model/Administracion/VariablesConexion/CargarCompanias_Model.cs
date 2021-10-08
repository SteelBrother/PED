using GrupoBIOS_PEDWEB.DT.DTOs;
using GrupoBIOS_PEDWEB.DT.Entidades;
using GrupoBIOS_PEDWEB.PWA.Helpers;
using GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces;
using GrupoBIOS_PEDWEB.PWA.Model.Administracion.VariablesConexion.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Model.Administracion.VariablesConexion
{
    public class CargarCompanias_Model : ICargarCompanias_Model
    {
        private readonly IConexionRest _conexion;
        private readonly ISettings _settings;
        private readonly IMostrarMensajes _mostrarMensajes;
        private readonly ILogger<ICargarCompanias_Model> _logger;
        public CargarCompanias_Model(IConexionRest conexion, ISettings settings, IMostrarMensajes mostrarMensajes, ILogger<ICargarCompanias_Model> logger)
        {
            _conexion = conexion;
            _settings = settings;
            _mostrarMensajes = mostrarMensajes;
            _logger = logger;
        }
        public async Task<List<Compania>> CargarCompañias()
        {
            try
            {
                var ApiUrl = await _settings.GetApiUrl();

                var httpResponse = await _conexion.Get<List<Compania>>($"{ApiUrl}/Companias");

                if (!httpResponse.Error)
                {
                    //await _mostrarMensajes.MostrarMensajeExitoso("Se ha cargado las compañias exitosamente.");
                    return httpResponse.Response.ToList();
                }
                //await _mostrarMensajes.MostrarMensajeError("No se ha podido cargar las compañias, intentelo de nuevo.");
                return new List<Compania>();

            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() != "WebAssembly.JSException" && ex.GetType().ToString() != "System.Net.Http.HttpRequestException" && ex.GetType().ToString() != "System.OperationCanceledException")
                {
                    _logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod().DeclaringType.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                    //await _mostrarMensajes.MostrarMensajeError("No se ha podido cargar la Compañia, intentelo de nuevo.");
                }
                return new List<Compania>();
            }
        }
    }
}
