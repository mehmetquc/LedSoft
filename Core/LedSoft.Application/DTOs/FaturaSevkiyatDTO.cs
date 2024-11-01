using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FaturaSevkiyatDTO
    {
        public long Id { get; set; }

        public long? Faturaid { get; set; }

        public string? SevkiyatTckn { get; set; }

        public string? SevkiyatAd { get; set; }

        public string? SevkiyatSoyad { get; set; }

        public string? SevkiyatPlaka { get; set; }

        public string? TasiyiciVkn { get; set; }

        public string? TasiyiciUnvan { get; set; }

        public string? SevkiyatGsm { get; set; }
    }
}
