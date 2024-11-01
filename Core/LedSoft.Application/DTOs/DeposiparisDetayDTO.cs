using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class DeposiparisDetayDTO
    {
        public long Id { get; set; }

        public long? Deposiparisid { get; set; }

        public long? Stokid { get; set; }

        public decimal? Miktar { get; set; }

        public long? Birimid { get; set; }

        public string? Aciklama { get; set; }

        public long? Ambalajbirimid { get; set; }

        public decimal? Ambalajmiktar { get; set; }

        public long? Varyasyonid { get; set; }

        public decimal? Carpan { get; set; }

        public decimal? Fiyat { get; set; }
    }
}
