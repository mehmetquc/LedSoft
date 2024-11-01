using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StokvirmanDTO
    {
        public long Id { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? Saat { get; set; }

        public string? Evrakno { get; set; }

        public long? Depoid { get; set; }

        public long? Subeid { get; set; }

        public string? Tip { get; set; }

        public string? Aciklama { get; set; }

        public long? Temsilciid { get; set; }

        public long? Projeid { get; set; }
    }
}
