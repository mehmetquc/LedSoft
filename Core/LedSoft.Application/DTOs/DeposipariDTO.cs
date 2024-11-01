using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class DeposipariDTO
    {
        public long Id { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? Saat { get; set; }

        public DateTime? Teslimtarih { get; set; }

        public long? Depoid { get; set; }

        public string? Aciklama { get; set; }

        public string? Durum { get; set; }

        public long? Sevkedildi { get; set; }

        public long? Depohareketid { get; set; }

        public long? Subeid { get; set; }

        public string? Evrakseri { get; set; }

        public long? Evraksira { get; set; }

        public long? Temsilciid { get; set; }

        public int? Gpsenlem { get; set; }

        public int? Gpsboylam { get; set; }

        public Guid? Udid { get; set; }

        public long? PerSiparisplandetayid { get; set; }
    }
}
