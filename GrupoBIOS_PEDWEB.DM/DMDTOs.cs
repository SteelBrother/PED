using GrupoBIOS_PEDWEB.DM.Interfaces;
using GrupoBIOS_PEDWEB.DT.DTOs;
using Insight.Database;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.DM
{
    public class DMDTOs 
    {
        private readonly IConfiguration _configuration;
        public DMDTOs(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public async Task<CompaniaDTO> ConstruirListaCompaniasDTO()
        //{
        //   var connection = new SqlConnection(_configuration.GetConnectionString("PEDWEBConnectionString"));
        //   var results = await connection.QueryResultsAsync<int, Compania>("SP_Siesa_ConsultarCompanias");
        //   CompaniasDTO Compania = new()
        //   {
        //       ListaCompanias = results.Set2.Count != 0 ? (List<Compania>)results.Set2 : new List<Compania>(),
        //   };
        //   return Compania;
        //}
    }
}
