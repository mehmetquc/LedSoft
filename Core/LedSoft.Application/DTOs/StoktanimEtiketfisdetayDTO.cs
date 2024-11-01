using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimEtiketfisdetayDTO
    {
        public long Id { get; set; }

        public long? Etiketfisid { get; set; }

        public long? Stokid { get; set; }

        public long? Birimid { get; set; }

        public int? Etiketadet { get; set; }

        public decimal? Fiyat { get; set; }

        public decimal? Fiyat2 { get; set; }

        public DateTime? Uretimtarih { get; set; }

        public DateTime? Sonkullanmatarih { get; set; }
    }
}
