using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimKoddonusumDetayDTO
    {
        public long Id { get; set; }

        public long? Urunanlasmaid { get; set; }

        public long? Stokid { get; set; }

        public string? Kod { get; set; }

        public string? Isim { get; set; }
    }
}
