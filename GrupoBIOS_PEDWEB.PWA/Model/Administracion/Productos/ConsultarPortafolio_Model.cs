using GrupoBIOS_PEDWEB.DT.Entidades;
using GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces;
using GrupoBIOS_PEDWEB.PWA.Model.Administracion.Productos.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Model.Administracion.Productos
{
    public class ConsultarPortafolio_Model : IConsultarPortafolio_Model
    {
        private readonly IConexionRest _conexion;
        private readonly ISettings _settings;
        private readonly IMostrarMensajes _mostrarMensajes;
        private readonly ILogger<ConsultarPortafolio_Model> _logger;
        public ConsultarPortafolio_Model(IConexionRest conexion, ISettings settings, IMostrarMensajes mostrarMensajes, ILogger<ConsultarPortafolio_Model> logger)
        {
            _conexion = conexion;
            _settings = settings;
            _mostrarMensajes = mostrarMensajes;
            _logger = logger;
        }
        public async Task<List<Portafolio>> ConsultarPortafolioPorCliente(int ClienteId, string SucursalId, int CompaniaId)
        {
            try
            {
                var ApiUrl = await _settings.GetApiUrl();
                var httpResponse = await _conexion.Get<List<Portafolio>>($"{ApiUrl}/Companias");

                if (httpResponse.Response != null)
                {
                    return httpResponse.Response.ToList();
                }
                return new List<Portafolio>();

            }
            catch (Exception ex)
            {
                if (ex.GetType().ToString() != "WebAssembly.JSException" && ex.GetType().ToString() != "System.Net.Http.HttpRequestException" && ex.GetType().ToString() != "System.OperationCanceledException")
                {
                    _logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod().DeclaringType.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                }
                return new List<Portafolio>();
            }
        }
    }
}
