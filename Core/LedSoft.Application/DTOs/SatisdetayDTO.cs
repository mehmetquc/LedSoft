using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class SatisdetayDTO
    {
        public long Id { get; set; }

        public long? Satisid { get; set; }

        public long? Stokid { get; set; }

        public decimal? Miktar { get; set; }

        public decimal? Fiyat { get; set; }

        public decimal? Iskonto { get; set; }

        public long? Varyasyonid { get; set; }

        public string? Temsilci { get; set; }

        public long? Satisdanismanid { get; set; }
    }
}
