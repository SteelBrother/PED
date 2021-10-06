using GrupoBIOS_PEDWEB.DT.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoBIOS_PEDWEB.DM.Interfaces
{
    public interface IDMDTOs
    {
        Task<CompaniaDTO> ConstruirListaCompaniasDTO();
    }
}
