using GrupoBIOS_PEDWEB.DT.Entidades;
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
    public class GuardarVariablesConexion_Model : IGuardarVariablesConexionModel
    {
        private readonly IConexionRest _conexion;
        private readonly ISettings _settings;
        private readonly IMostrarMensajes _mostrarMensajes;
        private readonly ILogger<GuardarVariablesConexion_Model> _logger;
        public GuardarVariablesConexion_Model(IConexionRest conexion, ISettings settings, IMostrarMensajes mostrarMensajes, ILogger<GuardarVariablesConexion_Model> logger)
        {
            _conexion = conexion;
            _settings = settings;
            _mostrarMensajes = mostrarMensajes;
            _logger = logger;
        }
        public async Task GuardarCompañia(Compania Compañia)
        {
            try
            {
                var ApiUrl = await _settings.GetApiUrl();

                var httpResponse = await _conexion.Post<Compania, Compania>($"{ApiUrl}/Compañias", Compañia);
                if (httpResponse.Error)
                {
                    _logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod().DeclaringType.Name}");
                    //await _mostrarMensajes.MostrarMensajeError("No se ha podido crear variables de conexion para la compañia, intentelo de nuevo.");
                }
                else
                {
                    //await _mostrarMensajes.MostrarMensajeExitoso("Se ha creado las variables de conexion de la compania exitosamente.");
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() != "WebAssembly.JSException" && ex.GetType().ToString() != "System.Net.Http.HttpRequestException" && ex.GetType().ToString() != "System.OperationCanceledException")
                {
                    _logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod().DeclaringType.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                    //await _mostrarMensajes.MostrarMensajeError("No se ha podido crear la Compañia, intentelo de nuevo.");
                }
            }
        }
    }
}
