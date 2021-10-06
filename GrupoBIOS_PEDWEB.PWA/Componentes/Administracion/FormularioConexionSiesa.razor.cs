using GrupoBIOS_PEDWEB.DT.Entidades;
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

    }
}
