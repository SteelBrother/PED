using GrupoBIOS_PEDWEB.DT.Entidades;
using GrupoBIOS_PEDWEB.PWA.Model.Administracion.Productos.Interfaces;
using GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.Productos.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.ViewModel.Administracion.Productos
{
    public class ConsultarPortafolio_ViewModel : IConsultarPortafolio_ViewModel
    {
        private readonly IConsultarPortafolio_Model _ConsultarPortafolio;
        private readonly ILogger<ConsultarPortafolio_ViewModel> _logger;
        public ConsultarPortafolio_ViewModel(IConsultarPortafolio_Model ConsultarPortafolio, ILogger<ConsultarPortafolio_ViewModel> logger)
        {
            _ConsultarPortafolio = ConsultarPortafolio;
            _logger = logger;
        }

        public Portafolio portafolio { get; set; }
        public List<Portafolio> ListaPortafolios { get; set; }

        public async Task CargarPortafolioPorCliente(int ClienteId, string SucursalId, int CompaniaId)
        {
            try
            {
                ListaPortafolios = await _ConsultarPortafolio.ConsultarPortafolioPorCliente(ClienteId, SucursalId, CompaniaId);
            }
            catch (Exception ex)
            {

                if (ex.GetType().ToString() != "WebAssembly.JSException" && ex.GetType().ToString() != "System.Net.Http.HttpRequestException" && ex.GetType().ToString() != "System.OperationCanceledException")
                {
                    _logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod().DeclaringType.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                }
            }
        }

    }
}
