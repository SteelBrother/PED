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
    public class CompaniaController : ControllerBase
    {
        private readonly IBMCompania _BMCompania;
        public CompaniaController(IBMCompania BMCompania)
        {
            _BMCompania = BMCompania;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Compania>>> Get()
        {
            return await _BMCompania.ObtenerCompanias();
        }

        //[HttpGet("{IdSiesa}")]
        //public async Task<ActionResult<Compania>> GetSucursalesPorCliente(int IdSiesa)
        //{
        //    return await _BMCompania.ObtenerCompaniasPorId(IdSiesa);   
        //}

        //[HttpPost]
        //public async Task<ActionResult<CompaniaDTO>> Post(CompaniaDTO Compania)
        //{
        //    return await _BMCompania.GuardarCompania(Compania);
        //}
    }
}
