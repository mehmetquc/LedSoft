using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class CarihareketDovizkurfarkiDTO
    {
        public long Id { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? Saat { get; set; }

        public string? Evrakno { get; set; }

        public long? Chid { get; set; }

        public long? Chid2 { get; set; }

        public DateTime? Vadetarih { get; set; }

        public string? Tip { get; set; }

        public string? Aciklama { get; set; }

        public decimal? Tutar { get; set; }

        public string? Dovizcinsi { get; set; }

        public string? Dovizcinsi2 { get; set; }

        public long? Subeid { get; set; }

        public long? Projeid { get; set; }

        public string? Hareketozelkod { get; set; }

        public long? Temsilciid { get; set; }

        public long? Cekid { get; set; }

        public decimal? Dovizkur { get; set; }
    }
}
