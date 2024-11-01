using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FiyatyonetimSablondetayDTO
    {
        public long Id { get; set; }

        public long? Sablonid { get; set; }

        public long? Fiyatlisteid { get; set; }

        public long? Fiyataltlisteid { get; set; }
    }
}
