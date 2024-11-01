using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class DepotanimAdreDTO
    {
        public long Id { get; set; }

        public long? Depoid { get; set; }

        public string? Kod { get; set; }

        public string? Isim { get; set; }

        public bool? Aktif { get; set; }

        public string? Barkod { get; set; }
    }
}
