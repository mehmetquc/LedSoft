using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimDepoDTO
    {
        public long Id { get; set; }

        public long? Stokid { get; set; }

        public long? Depoid { get; set; }

        public decimal? Minmiktar { get; set; }

        public decimal? Uygunmiktar { get; set; }

        public decimal? Maxmiktar { get; set; }
    }
}
