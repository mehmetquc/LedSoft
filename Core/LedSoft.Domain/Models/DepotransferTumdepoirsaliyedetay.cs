﻿using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class DepotransferTumdepoirsaliyedetay
{
    public long Id { get; set; }

    public long? Depotransferid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Miktar { get; set; }

    public long? Ambalajbirimid { get; set; }

    public decimal? Ambalajmiktar { get; set; }
}