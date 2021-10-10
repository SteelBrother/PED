using GrupoBIOS_PEDWEB.BM.Productos.Interfaces;
using GrupoBIOS_PEDWEB.DT.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PortafoliosController : ControllerBase
    {
        private readonly IBMPortafolio _BMPortafolio;
        public PortafoliosController(IBMPortafolio BMPortafolio)
        {
            _BMPortafolio = BMPortafolio;
        }

        [HttpGet("{IdCliente}/{SucursalId}/{Compañia}")]
        public async Task<ActionResult<ICollection<Portafolio>>> Get(int ClienteId, string SucursalId, int Compania)
        {
            return await _BMPortafolio.ObtenerPortafolioPorCliente(ClienteId,SucursalId,Compania);
        }
    }
}
