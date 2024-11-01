using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimAmbalajkullanimDTO
    {

        public long Id { get; set; }

        public long? Stokid { get; set; }

        public long? Ambalajbirimid { get; set; }

        public bool? Esikdegerkullan { get; set; }

        public decimal? Esikbuyukdeger { get; set; }

        public decimal? Esikkucukdeger { get; set; }
    }
}
