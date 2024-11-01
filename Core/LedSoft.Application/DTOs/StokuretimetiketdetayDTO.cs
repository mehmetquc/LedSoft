using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StokuretimetiketdetayDTO
    {
        public long Id { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? Saat { get; set; }

        public decimal? Miktar { get; set; }

        public string? Istasyonkod { get; set; }

        public DateTime? Skt { get; set; }

        public long? Stokid { get; set; }

        public long? Ciktiid { get; set; }

        public string? Partino { get; set; }

        public string? Serino { get; set; }

        public string? Personelkod { get; set; }
    }
}
