using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimChiletisimDTO
    {
        public long Id { get; set; }

        public string? Tip { get; set; }

        public string? Aciklama { get; set; }

        public string? Deger { get; set; }

        public long? Chid { get; set; }
    }
}
