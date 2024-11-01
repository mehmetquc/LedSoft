using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs.SiparisAllDTO
{
    public class SiparisAllsDTO
    {
        public long SiparisId { get; set; }
        public List<SparisGetAllDTO> SparisGetAll { get; set; }
    }
}
