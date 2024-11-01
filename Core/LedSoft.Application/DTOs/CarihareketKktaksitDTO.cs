using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class CarihareketKktaksitDTO
    {
        public long Id { get; set; }

        public long? Carihareketid { get; set; }

        public DateTime? Tarih { get; set; }

        public decimal? Tutar { get; set; }
    }
}
