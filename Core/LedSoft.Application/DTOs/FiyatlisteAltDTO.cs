using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FiyatlisteAltDTO
    {
        public long Id { get; set; }

        public long? Fiyatlisteid { get; set; }

        public string? Aciklama { get; set; }

        public bool? Ilktarihvar { get; set; }

        public DateTime? Ilktarih { get; set; }

        public bool? Sontarihvar { get; set; }

        public DateTime? Sontarih { get; set; }

        public bool? Kdvdahil { get; set; }

        public bool? Onay1 { get; set; }

        public bool? Onay2 { get; set; }

        public long? Onay1userid { get; set; }

        public long? Onay2userid { get; set; }

        public int? Sevkadressecimtip { get; set; }

        public bool? Aktif { get; set; }
    }
}
