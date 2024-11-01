using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimPsAnlasmaDTO
    {
        public long Id { get; set; }

        public long? Posid { get; set; }

        public decimal? Kesinti { get; set; }

        public bool? Aktif { get; set; }

        public string? Aciklama { get; set; }

        public int? Vadegun { get; set; }
    }
}
