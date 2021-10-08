using GrupoBIOS_PEDWEB.DT.DTOs;
using GrupoBIOS_PEDWEB.DT.Entidades;
using MatBlazor;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.PWA.Componentes.Administracion
{
    public partial class FormularioConexionSiesaBase : ComponentBase
    {
        [Parameter] public Compania Compania { get; set; }
        [Parameter] public EventCallback OnValidSubmit { get; set; }
        [Parameter] public List<Compania> ListaCompanias { get; set; }
        [Parameter] public int CompaniaId { get; set; }
        [Inject] IMatDialogService MatDialogService { get; set; }

        public string CompaniaSeleccionada = "";

        public void CompaniaHasChanged(ChangeEventArgs e)
        {
            CompaniaSeleccionada = e.Value.ToString();            
        }

        async Task AgregarCompania(Compania compania) 
        {

        }

        string value1 = "2";

        public int[] value1Items = new[]
        {
                1,
                2,
                3,
                4,
                5,
            };

        public async Task OpenPromptFromService()
        {
            var result = await MatDialogService.PromptAsync("What is your name?");
        }
    }
}
