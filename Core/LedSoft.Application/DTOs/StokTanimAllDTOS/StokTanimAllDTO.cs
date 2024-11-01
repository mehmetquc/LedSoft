using LedSoft.Application.ResponseModels;
using LedSoft.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs.StokTanimAllDTOS
{
    public class StokTanimAllDTO
    {
        public Stoktanim StokTanims { get; set; }
        public StoktanimBarkod StokTanimBarkods { get; set; }

        public StoktanimVaryasyon StokTanimVaryasyons { get; set; }
        public FiyatlisteDetay FiyatlisteDetays { get; set; }

        public Fiyatliste Fiyatlistes { get; set; }
    }
}
