using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FiyatanlasmaDetayDTO
    {
        public long Id { get; set; }

        public long? Fiyatanlasmaid { get; set; }

        public long? Stokid { get; set; }

        public decimal? Fiyat { get; set; }

        public decimal? Iskonto1 { get; set; }

        public decimal? Iskonto2 { get; set; }

        public decimal? Iskonto3 { get; set; }

        public decimal? Iskonto4 { get; set; }

        public decimal? Iskonto5 { get; set; }
    }
}
