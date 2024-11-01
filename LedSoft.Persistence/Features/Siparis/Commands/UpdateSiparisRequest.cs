using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Siparis.Commands
{
    public class UpdateSiparisRequest:IRequest<ServiceResponse<SipariDTO>>
    {
        public long Id { get; set; }

        public long? Chid { get; set; }

        public long? Depoid { get; set; }

        public DateTime? Tarih { get; set; }

        public DateTime? Saat { get; set; }

        public string? Evrakno { get; set; }

        public string? Aciklama { get; set; }

        public decimal? Iskonto1 { get; set; }

        public decimal? Iskonto2 { get; set; }

        public decimal? Iskonto3 { get; set; }

        public string? Tip { get; set; }

        public DateTime? Vadetarih { get; set; }

        public DateTime? Teslimtarih { get; set; }

        public int? Onay { get; set; }

        public int? Odemesekli { get; set; }

        public string? Sevkiyatnotu { get; set; }

        public bool? Kdvdahil { get; set; }

        public long? Temsilciid { get; set; }

        public long? Projeid { get; set; }

        public string? Ozelkod { get; set; }

        public string? Dovizcinsi { get; set; }

        public decimal? Dovizkur { get; set; }

        public int? Sevkadres { get; set; }

        public int? Sevkadresid { get; set; }

        public int? Ziyaretid { get; set; }

        public string? Evrakseri { get; set; }

        public string? Evraksira { get; set; }

        public bool? B2b { get; set; }

        public int? Subeid { get; set; }

        public long? Gpsenlem { get; set; }

        public long? Gpsboylam { get; set; }

        public DateTime? Uretimtarih { get; set; }

        public string? Uretimdurum { get; set; }

        public Guid? Udid { get; set; }

        public string? Detayaciklama { get; set; }

        public string? Odemetip { get; set; }

        public bool? Yazdirildi { get; set; }

        public byte[]? Gorsel { get; set; }
    }
}
