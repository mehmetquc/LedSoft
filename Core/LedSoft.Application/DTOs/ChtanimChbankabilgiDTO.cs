using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimChbankabilgiDTO
    {
        public long Id { get; set; }

        public long? Chid { get; set; }

        public string? Isim { get; set; }

        public string? Subekod { get; set; }

        public string? Subeisim { get; set; }

        public string? Hesapno { get; set; }

        public string? Ibanno { get; set; }
    }
}
