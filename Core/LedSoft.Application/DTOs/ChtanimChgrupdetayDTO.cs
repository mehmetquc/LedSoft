using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimChgrupdetayDTO
    {
        public long Id { get; set; }

        public long? Chgrupid { get; set; }

        public long? Chid { get; set; }

        public bool? Aktif { get; set; }

        public long? Sevkadresid { get; set; }

        public int? Sira { get; set; }
    }
}
