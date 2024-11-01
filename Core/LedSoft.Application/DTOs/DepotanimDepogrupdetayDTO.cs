using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class DepotanimDepogrupdetayDTO
    {
        public long Id { get; set; }

        public long? Depogrupid { get; set; }

        public long? Depoid { get; set; }

        public bool? Aktif { get; set; }
    }
}
