using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FiyatyonetimStokdegerDTO
    {
        public long Id { get; set; }

        public long? Stokid { get; set; }

        public decimal? Indirimyuzde { get; set; }

        public decimal? Indirimtutar { get; set; }

        public decimal? Artirimyuzde { get; set; }

        public decimal? Artirimtutar { get; set; }
    }
}
