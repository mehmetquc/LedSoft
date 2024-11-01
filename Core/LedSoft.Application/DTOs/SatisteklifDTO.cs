using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class SatisteklifDTO
    {
        public long Id { get; set; }

        public long? Chid { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? Saat { get; set; }

        public long? Temsilciid { get; set; }

        public string? Teklifno { get; set; }

        public string? Konu { get; set; }

        public string? Yetkili { get; set; }

        public long? Ekdokumansayisi { get; set; }

        public string? Kosul { get; set; }

        public string? Teklifnot { get; set; }

        public int? Opsiyongun { get; set; }

        public long? Teslimgun { get; set; }

        public long? Odemegun { get; set; }

        public long? Siparisid { get; set; }

        public long? Subeid { get; set; }
    }
}
