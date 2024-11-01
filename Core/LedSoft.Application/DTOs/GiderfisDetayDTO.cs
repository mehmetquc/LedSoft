using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class GiderfisDetayDTO
    {
        public long Id { get; set; }

        public long? Fisid { get; set; }

        public long? Hizmetid { get; set; }

        public decimal? Miktar { get; set; }

        public long? Birimid { get; set; }

        public decimal? Fiyat { get; set; }

        public decimal? Kdvoran { get; set; }

        public long? Temsilciid { get; set; }

        public string? Aciklama { get; set; }

        public string? Fisno { get; set; }
    }
}
