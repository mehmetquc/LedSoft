﻿using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wcarikart
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Tabelaisim { get; set; }

    public string? Dovizcinsi { get; set; }

    public bool Zorunluparabirimi { get; set; }

    public long? Detayid { get; set; }

    public string? Adres { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Renkkodu { get; set; }

    public string? Vergidaire { get; set; }

    public string? Vergino { get; set; }

    public string? Tapdkno { get; set; }

    public string? Ticarisicilno { get; set; }

    public string? Yetkili { get; set; }

    public string? Yetkiliadres { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Fax { get; set; }

    public string? Gsm { get; set; }

    public string? Web { get; set; }

    public string? Eposta { get; set; }

    public string? Ozelkod1 { get; set; }

    public string? Ozelkod2 { get; set; }

    public string? Ozelkod3 { get; set; }

    public string? Ozelkod4 { get; set; }

    public string? Ozelkod5 { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public int? Muafiyet { get; set; }

    public decimal? Kredilimit { get; set; }

    public decimal? Risklimit { get; set; }

    public bool? Stokiskonto1var { get; set; }

    public bool? Stokiskonto2var { get; set; }

    public bool? Stokiskonto3var { get; set; }

    public int? Kdvkriteri { get; set; }

    public int? Fiyatkriteri { get; set; }

    public long? Fiyatlisteid { get; set; }

    public long? Iskontolisteid { get; set; }

    public long? Alisfiyatlisteid { get; set; }

    public string? Entegrasyonkod1 { get; set; }

    public string? Entegrasyonkod2 { get; set; }

    public string? Entegrasyonkod3 { get; set; }

    public string? Entegrasyonkod4 { get; set; }

    public string? Entegrasyonkod5 { get; set; }

    public string? Musterimuhasebekodu { get; set; }

    public string? Saticimuhasebekodu { get; set; }

    public bool? Kdvdahil { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public string? B2bkullaniciadi { get; set; }

    public string? B2bparola { get; set; }

    public bool? Efaturakullaniyor { get; set; }

    public int? Kategori1id { get; set; }

    public int? Kategori2id { get; set; }

    public int? Kategori3id { get; set; }

    public int? Kategori4id { get; set; }

    public int? Kategori5id { get; set; }

    public int? Kategori6id { get; set; }

    public int? Kategori7id { get; set; }

    public int? Kategori8id { get; set; }

    public int? Kategori9id { get; set; }

    public int? Kategori10id { get; set; }

    public DateTime? Acilistarih { get; set; }

    public bool TerminalislemKullan { get; set; }

    public bool? TerminalislemF2 { get; set; }

    public bool? TerminalislemI2 { get; set; }

    public bool? TerminalislemFb { get; set; }

    public long? TerminalciktiprofilidF2 { get; set; }

    public long? TerminalciktiprofilidI2 { get; set; }

    public long? TerminalciktiprofilidFb { get; set; }

    public bool? Aktif { get; set; }

    public int Subeid { get; set; }

    public string? Ekalan1 { get; set; }

    public string? Ekalan2 { get; set; }

    public string? Ekalan3 { get; set; }

    public string? Ekalan4 { get; set; }

    public string? Ekalan5 { get; set; }

    public string? Ekalan6 { get; set; }

    public string? Ekalan7 { get; set; }

    public string? Ekalan8 { get; set; }

    public string? Ekalan9 { get; set; }

    public string? Ekalan10 { get; set; }

    public bool? TerminalyetkiFiyatdegistirme { get; set; }

    public string? MobilFiyatdegistirme { get; set; }

    public string? MobilGpskonumkisitlama { get; set; }

    public long? Temsilciid { get; set; }

    public string? Barkod { get; set; }

    public long? LedmuhMusterihesapid { get; set; }

    public long? LedmuhSaticihesapid { get; set; }

    public string? Dijitaltel { get; set; }

    public long? Depoid { get; set; }

    public string? Ulke { get; set; }

    public string? MobilIskontofiyatyansitma { get; set; }

    public bool? MobilEvraknoayritakipet { get; set; }

    public string? MobilKredilimityetki { get; set; }

    public string? MobilRisklimityetki { get; set; }

    public string? MobilVadelimityetki { get; set; }

    public bool? MobilPartinotakip { get; set; }

    public bool Smsizin { get; set; }

    public string? Ad { get; set; }

    public string? Soyad { get; set; }

    public bool Epostaizin { get; set; }

    public string? EmutabakatEposta { get; set; }

    public string? AsistanEposta { get; set; }

    public string? EarsivEposta { get; set; }

    public string? EbabsEposta { get; set; }

    public string Ebelgekullan { get; set; } = null!;

    public bool Satisyapma { get; set; }

    public string? SatisyapmaSebep { get; set; }

    public string? Carisecimnotu { get; set; }

    public bool CarisecimnotuMasaustu { get; set; }

    public bool CarisecimnotuMobil { get; set; }

    public string? MobilFiyatliirsaliye { get; set; }

    public string? EfaturaOzelkod { get; set; }

    public string? EfaturaOzeldeger { get; set; }

    public string? EfaturaOzelkod2 { get; set; }

    public string? EfaturaOzeldeger2 { get; set; }

    public string? EmutabakatYetkili { get; set; }

    public bool? Eirsaliyekullaniyor { get; set; }

    public string? MobilCevrimicilimitkontrol { get; set; }

    public string? Postakodu { get; set; }

    public string? EfaturaSenaryo { get; set; }

    public string MobilMaxiskonto1kullanim { get; set; } = null!;

    public string MobilMaxiskonto2kullanim { get; set; } = null!;

    public string MobilMaxiskonto3kullanim { get; set; } = null!;
}
