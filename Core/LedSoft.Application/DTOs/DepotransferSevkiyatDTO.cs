using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class DepotransferSevkiyatDTO
    {
        public long Id { get; set; }

        public long? Depotransferid { get; set; }

        public string? SevkiyatTckn { get; set; }

        public string? SevkiyatAd { get; set; }

        public string? SevkiyatSoyad { get; set; }

        public string? SevkiyatPlaka { get; set; }

        public long? SevkiyatTasiyicichid { get; set; }

        public string? SevkiyatTasiyicivkn { get; set; }

        public string? SevkiyatTasiyiciunvan { get; set; }
    }
}
