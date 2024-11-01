using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimKoddonusumCariDTO
    {
        public long Id { get; set; }

        public long? Urunanlasmaid { get; set; }

        public long? Chid { get; set; }

        public bool? Aktif { get; set; }
    }
}
