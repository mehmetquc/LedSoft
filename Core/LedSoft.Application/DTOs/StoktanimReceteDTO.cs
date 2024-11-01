using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimReceteDTO
    {
        public long Id { get; set; }

        public long? Stokid { get; set; }

        public long? Recetestokid { get; set; }

        public decimal? Miktar { get; set; }

        public long? Birimid { get; set; }
    }
}
