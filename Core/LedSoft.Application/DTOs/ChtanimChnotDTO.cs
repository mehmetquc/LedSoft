using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimChnotDTO
    {
        public long Id { get; set; }

        public long? Chid { get; set; }

        public string? Aciklama { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? Saat { get; set; }
    }
}
