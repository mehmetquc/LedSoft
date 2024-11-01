using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StokuretimetiketDTO
    {
        public long Id { get; set; }

        public long? Stokid { get; set; }

        public string? Stokkod { get; set; }

        public string? Stokisim { get; set; }

        public string? Kategori1 { get; set; }

        public string? Kategori2 { get; set; }

        public string? Aciklama1 { get; set; }

        public string? Aciklama2 { get; set; }

        public string? Aciklama3 { get; set; }

        public string? Aciklama4 { get; set; }

        public string? Aciklama5 { get; set; }

        public long? Dizaynid { get; set; }

        public bool? Aktif { get; set; }

        public string? Barkod { get; set; }

        public long? Stokuretimetiketdepartmanid { get; set; }
    }
}
