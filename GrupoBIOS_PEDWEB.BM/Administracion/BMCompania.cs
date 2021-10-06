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

        public async Task<ActionResult<ICollection<Compania>>> ObtenerCompanias()
        {
            try
            {
                var Companias = await _conexionBD.QueryAsync<Compania>("SP_Siesa_ConsultarCompanias");
                return Companias.ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ha ocurrido un {GetType().Name}/{MethodBase.GetCurrentMethod().DeclaringType.Name}: {ex.Message}");
                return null;
            }
        }
    }
}
