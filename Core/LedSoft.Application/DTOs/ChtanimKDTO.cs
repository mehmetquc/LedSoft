using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimKDTO
    {
        public long Id { get; set; }

        public long? Chid { get; set; }

        public string? Muhasebekodu { get; set; }

        public string? Aciklama { get; set; }

        public long? LedmuhHesapid { get; set; }
    }
}
