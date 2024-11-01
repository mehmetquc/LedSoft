﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimPerakendedepartmanDTO
    {
        public long Id { get; set; }

        public string? Kod { get; set; }

        public string? Isim { get; set; }

        public decimal? Kdvyuzde { get; set; }

        public string? Entegrasyonkod { get; set; }

        public bool? Aktif { get; set; }
    }
}