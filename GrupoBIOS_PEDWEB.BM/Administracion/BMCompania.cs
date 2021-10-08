using GrupoBIOS_PEDWEB.BM.Administracion.Interfaces;
using GrupoBIOS_PEDWEB.DM.DataBase.Interfaces;
using GrupoBIOS_PEDWEB.DT.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.BM.Administracion
{
    public class BMCompania : IBMCompania
    {
        private readonly IConexionBD _conexionBD;
        private readonly ILogger<IBMCompania> _logger;
        public BMCompania(IConexionBD conexionBD, ILogger<IBMCompania> logger)
        {
            _conexionBD = conexionBD;
            _logger = logger;
        }

       

        public async Task<ActionResult<Compania>> ObtenerCompaniaPorId(int Id)
        {
            try
            {
                var response = await _conexionBD.QueryFirstAsync<Compania>("SP_Siesa_ObtenerCompaniaPorId", Id);
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ha ocurrido un {GetType().Name}/{MethodBase.GetCurrentMethod().DeclaringType.Name}: {ex.Message}");
                return null;
            }
        }

        public async Task<ActionResult<ICollection<Compania>>> ObtenerCompanias()
        {
            try
            {
                var response = await _conexionBD.QueryAsync<Compania>("SP_Siesa_ConsultarCompanias");
                return response.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ha ocurrido un {GetType().Name}/{MethodBase.GetCurrentMethod().DeclaringType.Name}: {ex.Message}");
                return null;
            }
        }

        public async Task<ActionResult<List<string>>> ActualizarCompañia(Compania Compañia)
        {
            try
            {
                var response = await _conexionBD.QueryAsync<string>("SP_Siesa_ActualizarCompania", Compañia);
                return response.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ha ocurrido un {GetType().Name}/{MethodBase.GetCurrentMethod().DeclaringType.Name}: {ex.Message}");
                return null;
            }
        }

        public async Task<ActionResult<List<string>>> GuardarCompañia(Compania Compañia)
        {
            try
            {
                var response = await _conexionBD.QueryAsync<string>("SP_Siesa_GuardarCompania", Compañia);
                return response.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ha ocurrido un {GetType().Name}/{MethodBase.GetCurrentMethod().DeclaringType.Name}: {ex.Message}");
                return null;
            }
        }
    }
}
