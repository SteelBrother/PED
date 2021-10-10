using GrupoBIOS_PEDWEB.BM.Productos.Interfaces;
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

namespace GrupoBIOS_PEDWEB.BM.Productos
{
    public class BMPortafolio : IBMPortafolio
    {
        private readonly IConexionBD _conexionBD;
        private readonly ILogger<BMPortafolio> _logger;
        public BMPortafolio(IConexionBD conexionBD, ILogger<BMPortafolio> logger)
        {
            _conexionBD = conexionBD;
            _logger = logger;
        }
        public async Task<ActionResult<ICollection<Portafolio>>> ObtenerPortafolioPorCliente(int ClienteId, string SucursalId, int CompaniaId)
        {
            try
            {
                var response = await _conexionBD.QueryAsync<Portafolio>("SP_Siesa_PortafolioPorCliente", new { ClienteId, SucursalId, CompaniaId });
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
