using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces
{
    public interface IMostrarMensajes
    {
        Task<bool> MostrarMensajeConfirmacion(string titulo, string Mensaje, string Icono);
        Task MostrarMensajeError(string mensaje);
        Task MostrarMensajeExitoso(string mensaje);
        Task<string> MostrarMensajeTextoConfirmacion(string titulo, string Mensaje, string Value);
    }
}
