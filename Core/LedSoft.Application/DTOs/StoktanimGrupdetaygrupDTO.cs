using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimGrupdetaygrupDTO
    {
        public long Id { get; set; }

        public long? Stokgrupid { get; set; }

        public long? Grupid { get; set; }

        public bool? Aktif { get; set; }
    }
}
