using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimBirimcevrimDTO
    {
        public long Id { get; set; }

        public int? Stokid { get; set; }

        public long? Birimid { get; set; }

        public decimal? Carpan { get; set; }
    }
}
