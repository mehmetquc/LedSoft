using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FaturaInternetsatiDTO
    {
        public long Id { get; set; }

        public long? Faturaid { get; set; }

        public bool? InternetsatisVar { get; set; }

        public string? InternetsatisWebadres { get; set; }

        public string? InternetsatisOdemesekli { get; set; }

        public string? InternetsatisOdemesekliaraci { get; set; }

        public DateTime? InternetsatisOdemetarih { get; set; }

        public long? InternetsatisTasiyicichid { get; set; }

        public DateTime? InternetsatisGonderimtarih { get; set; }
    }
}
