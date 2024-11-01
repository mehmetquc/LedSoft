using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimGgDTO
    {
        public long Id { get; set; }

        public long? Chid { get; set; }

        public string? Ozelkod { get; set; }

        public bool? Kalemozelkodvar { get; set; }

        public string? Muhasebekodu { get; set; }

        public string? Kdvmuhasebekodu { get; set; }

        public int? Karttip { get; set; }

        public int? Kategori1id { get; set; }

        public int? Kategori2id { get; set; }

        public int? Kategori3id { get; set; }

        public long? LedmuhHesapid { get; set; }

        public long? Kategori4id { get; set; }

        public long? Kategori5id { get; set; }
    }
}
