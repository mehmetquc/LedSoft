using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FaturaFiyatfarkidetayDTO
    {
        public long Id { get; set; }

        public long? Faturaid { get; set; }

        public long? Faturdetayid { get; set; }

        public long? Stokid { get; set; }

        public decimal? Kdv { get; set; }

        public string? Aciklama { get; set; }

        public decimal? Tutar { get; set; }
    }
}
