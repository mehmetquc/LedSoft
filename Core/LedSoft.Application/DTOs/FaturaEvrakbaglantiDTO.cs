using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FaturaEvrakbaglantiDTO
    {
        public long Id { get; set; }

        public long? Faturaid { get; set; }

        public long? Irsaliyeid { get; set; }

        public long? Siparisid { get; set; }
    }
}
