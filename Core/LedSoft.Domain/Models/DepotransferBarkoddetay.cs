﻿using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class DepotransferBarkoddetay
{
    public long Id { get; set; }

    public long? Depotransferid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Miktar { get; set; }

    public string? Barkod { get; set; }

    public string? Partino { get; set; }

    public DateTime? Skt { get; set; }
}
