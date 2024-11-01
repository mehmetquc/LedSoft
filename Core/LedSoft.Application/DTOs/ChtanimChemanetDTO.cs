using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class ChtanimChemanetDTO
    {
        public long Id { get; set; }

        public long? Chid { get; set; }

        public DateTime? Baslangictarih { get; set; }

        public DateTime? Bitistarih { get; set; }

        public string? Serino { get; set; }

        public string? Aciklama { get; set; }

        public string? Marka { get; set; }

        public string? Model { get; set; }

        public bool? Aktif { get; set; }

        public byte[]? Resim1 { get; set; }

        public byte[]? Resim2 { get; set; }

        public byte[]? Resim3 { get; set; }

        public byte[]? Resim4 { get; set; }

        public long? Sevkadresid { get; set; }

        public long? Emanetid { get; set; }

        public bool? Bitistarihvar { get; set; }
    }
}
