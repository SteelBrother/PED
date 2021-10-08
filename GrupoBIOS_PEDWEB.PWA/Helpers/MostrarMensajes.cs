using GrupoBIOS_PEDWEB.PWA.Helpers.Interfaces;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        private readonly IJSRuntime js;

        public MostrarMensajes(IJSRuntime js)
        {
            this.js = js;
        }

        public async Task<bool> MostrarMensajeConfirmacion(string titulo, string Mensaje, string Icono)
        {
            return await js.InvokeAsync<bool>("mostrarMensajeConfirmacion", titulo, Mensaje, Icono);
        }

        public async Task<string> MostrarMensajeTextoConfirmacion(string titulo, string Mensaje, string Value)
        {
            return await js.InvokeAsync<string>("mostrarMensajeTextoConfirmacion", titulo, Mensaje, Value);
        }

        //public async Task MostrarMensajeError(string mensaje)
        //{
        //    await MostrarMensaje("Error", mensaje, "error");
        //}

        //public async Task MostrarMensajeExitoso(string mensaje)
        //{
        //    await MostrarMensaje("Exitoso", mensaje, "success");
        //}

   
        private async ValueTask MostrarMensaje(string titulo, string mensaje, string tipoMensaje)
        {
            await js.InvokeVoidAsync("Swal.fire", titulo, mensaje, tipoMensaje);
        }
    }
}

