using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class DepotransferTumdepoirsaliyedetayDTO
    {
        public long Id { get; set; }

        public long? Depotransferid { get; set; }

        public long? Stokid { get; set; }

        public long? Birimid { get; set; }

        public decimal? Carpan { get; set; }

        public decimal? Miktar { get; set; }

        public long? Ambalajbirimid { get; set; }

        public decimal? Ambalajmiktar { get; set; }
    }
}
