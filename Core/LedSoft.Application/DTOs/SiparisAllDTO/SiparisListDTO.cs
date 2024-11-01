using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs.SiparisAllDTO
{
    public class SiparisListDTO
    {
        public long Id { get; set; }//

        public long? Chid { get; set; }//
        public string? CariKod { get; set; }

        public string? CariIsim { get; set; }
        public DateTime? Tarih { get; set; }//

        public DateTime? Saat { get; set; }//

        public string? Evrakno { get; set; }//

        public string? Aciklama { get; set; }//

        public string? Detayaciklama { get; set; }//
        public decimal? Maltoplam { get; set; }//
        public decimal? Kdvtoplam { get; set; }//
        public decimal? Tutar { get; set; }//


    }
}
