﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimLisanDTO
    {
        public long Id { get; set; }

        public string? Dil { get; set; }

        public long? Stokid { get; set; }

        public string? Isim { get; set; }
    }
}
