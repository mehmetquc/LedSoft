using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FaturaBarkoddetayDTO
    {
        public long Id { get; set; }

        public long? Faturaid { get; set; }

        public long? Stokid { get; set; }

        public long? Birimid { get; set; }

        public decimal? Miktar { get; set; }

        public string? Barkod { get; set; }

        public string? Partino { get; set; }

        public DateTime? Skt { get; set; }
    }
}
