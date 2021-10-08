using GrupoBIOS_PEDWEB.BM.Administracion.Interfaces;
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
    public class CompaniasController : ControllerBase
    {
        private readonly IBMCompania _BMCompania;
        public CompaniasController(IBMCompania BMCompania)
        {
            _BMCompania = BMCompania;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Compania>>> Get()
        {
            return await _BMCompania.ObtenerCompanias();
        }

        [HttpGet("{IdSiesa}")]
        public async Task<ActionResult<Compania>> GetCompaniaPorId(int IdSiesa)
        {
            return await _BMCompania.ObtenerCompaniaPorId(IdSiesa);
        }

        [HttpPost]
        public async Task<ActionResult<List<string>>> Post(Compania Compania)
        {
            var response = await _BMCompania.GuardarCompañia(Compania);
            return response;

        }

        [HttpPut]
        public async Task<ActionResult<List<string>>> Put(Compania Compania)
        {
            var Compañia = await _BMCompania.ActualizarCompañia(Compania);
            return Compañia;
        }
    }
}
