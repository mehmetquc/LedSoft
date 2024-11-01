using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StokvirmanGirisDTO
    {
        public long Id { get; set; }

        public long? Stokid { get; set; }

        public long? Birimid { get; set; }

        public decimal? Miktar { get; set; }

        public decimal? Carpan { get; set; }

        public decimal? Fiyat { get; set; }

        public decimal? Tutar { get; set; }

        public long? Ambalajbirimid { get; set; }

        public decimal? Ambalajmiktar { get; set; }

        public long? Stokvirmanid { get; set; }

        public string? Partino { get; set; }

        public string? Serino { get; set; }

        public long? Depoid { get; set; }
    }
}
