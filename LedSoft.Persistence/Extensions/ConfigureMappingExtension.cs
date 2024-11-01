using AutoMapper;
using LedSoft.Application.DTOs;
using LedSoft.Persistence.Features.Cari.Commands;
using LedSoft.Persistence.Features.Siparis.Commands;
using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Persistence.Features.StokTanimBarkod.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Extensions
{
    public static class ConfigureMappingExtension
    {
        public static IServiceCollection ConfigureMapping(this IServiceCollection service)
        {
            var mappingConfig = new MapperConfiguration(mc => { mc.AddProfile(new MappingProfile()); });

            IMapper mapper = mappingConfig.CreateMapper();

            service.AddSingleton(mapper);

            return service;
        }
        public class MappingProfile : Profile
        {
            public MappingProfile()
            {
                //Carihareket

                CreateMap<CarihareketDovizislem,CarihareketDovizislemDTO>().ReverseMap();
                CreateMap<CarihareketDovizkurfarki,CarihareketDovizkurfarkiDTO>().ReverseMap();
                CreateMap<Carihareket,CarihareketDTO>().ReverseMap();
                CreateMap<CarihareketFi,CarihareketFiDTO>().ReverseMap();
                CreateMap<CarihareketKktaksit,CarihareketKktaksitDTO>().ReverseMap();
                
                //Chtanim

                CreateMap<Chtanim, ChtanimDTO>().ReverseMap();
                CreateMap<CreateChtanimRequest, Chtanim>().ReverseMap();

                CreateMap<ChtanimBankakredi, ChtanimBankakrediDTO>().ReverseMap();
                CreateMap<ChtanimBankakrediodemeplan,ChtanimBankakrediodemeplanDTO>().ReverseMap();
                CreateMap<ChtanimChadre, ChtanimChadreDTO>().ReverseMap();
                CreateMap<ChtanimChbankabilgi, ChtanimChbankabilgiDTO>().ReverseMap();
                CreateMap<ChtanimCh,ChtanimChDTO>().ReverseMap();
                CreateMap<ChtanimChemanet, ChtanimChemanetDTO>().ReverseMap();
                CreateMap<ChtanimChgrupdetay,ChtanimChgrupdetayDTO>().ReverseMap(); 
                CreateMap<ChtanimChgrup, ChtanimChgrupDTO>().ReverseMap();
                CreateMap<ChtanimChiletisim, ChtanimChiletisimDTO>().ReverseMap();
                CreateMap<ChtanimChnot, ChtanimChnotDTO>().ReverseMap();
                CreateMap<ChtanimGg, ChtanimGgDTO>().ReverseMap();
                CreateMap<ChtanimGgkalem, ChtanimGgkalemDTO>().ReverseMap();
                CreateMap<ChtanimGidergrup, ChtanimGidergrupDTO>().ReverseMap();
                CreateMap<ChtanimKDTO, ChtanimKDTO>().ReverseMap();
                CreateMap<ChtanimKk, ChtanimKkDTO>().ReverseMap();
                CreateMap<ChtanimP, ChtanimPDTO>().ReverseMap();
                CreateMap<ChtanimPersonel, ChtanimPersonelDTO>().ReverseMap();
                CreateMap<ChtanimPortfoy, ChtanimPortfoyDTO>().ReverseMap();
                CreateMap<ChtanimPosgrupdetay, ChtanimPosgrupDTO>().ReverseMap();
                CreateMap<ChtanimPosgrup,ChtanimPosgrupDTO>().ReverseMap();
                CreateMap<ChtanimPsAnlasma, ChtanimPsAnlasmaDTO>().ReverseMap();
                CreateMap<ChtanimTeminatmektup,ChtanimTeminatmektupDTO>().ReverseMap();
                CreateMap<ChtanimTeminatmektupHukumluluk,ChtanimTeminatmektupHukumlulukDTO>().ReverseMap();
                
                //Depo

                CreateMap<Deposipari, DeposipariDTO>().ReverseMap();
                CreateMap<DeposiparisDetay, DeposiparisDetayDTO>().ReverseMap();
                CreateMap<DepotanimAdre, DepotanimAdreDTO>().ReverseMap();
                CreateMap<DepotanimDepogrupdetay, DepotanimDepogrupdetayDTO>().ReverseMap();
                CreateMap<DepotanimDepogrup, DepotanimDepogrupDTO>().ReverseMap();
                CreateMap<Depotanim, DepotanimDTO>().ReverseMap();
                CreateMap<DepotransferBarkoddetay, DepotransferBarkoddetayDTO>().ReverseMap();
                CreateMap<DepotransferDetay, DepotransferDetayDTO>().ReverseMap();
                CreateMap<Depotransfer, DepotransferDTO>().ReverseMap();
                CreateMap<DepotransferSevkiyat, DepotransferSevkiyatDTO>().ReverseMap();
                CreateMap<DepotransferTumdepoirsaliyedetay, DepotransferTumdepoirsaliyedetayDTO>().ReverseMap();



                //Fatura

                CreateMap<FaturaBarkoddetay,FaturaBarkoddetayDTO>().ReverseMap();
                CreateMap<FaturaDeger,FaturaDegerDTO>().ReverseMap();
                CreateMap<FaturaDetay,FaturaDetayDTO>().ReverseMap();
                CreateMap<Fatura,FaturaDTO>().ReverseMap();
                CreateMap<FaturaEvrakbaglanti,FaturaEvrakbaglantiDTO>().ReverseMap();
                CreateMap<FaturaFiyatfarkidetay,FaturaFiyatfarkidetayDTO>().ReverseMap();
                CreateMap<FaturaIhracat, FaturaIhracatDTO>().ReverseMap();
                CreateMap<FaturaInternetsati,FaturaInternetsatiDTO>().ReverseMap();
                CreateMap<FaturaMasrafkalem,FaturaMasrafkalemDTO>().ReverseMap();
                CreateMap<FaturaSevkiyat,FaturaSevkiyatDTO>().ReverseMap();

                //Fiyat

                CreateMap<FiyatanlasmaDetay,FiyatanlasmaDetayDTO>().ReverseMap();
                CreateMap<Fiyatanlasma,FiyatanlasmaDTO>().ReverseMap();
                CreateMap<FiyatlisteAlt,FiyatlisteAltDTO>().ReverseMap();
                CreateMap<FiyatlisteAltsevkadre, FiyatlisteAltsevkadreDTO>().ReverseMap();
                CreateMap<FiyatlisteCari,FiyatlisteCariDTO>().ReverseMap();
                CreateMap<FiyatlisteCarigrup, FiyatlisteCarigrupDTO>().ReverseMap();
                CreateMap<FiyatlisteCarikategori, FiyatlisteCarikategoriDTO>().ReverseMap();
                CreateMap<FiyatlisteDetay,FiyatlisteDetayDTO>().ReverseMap();
                CreateMap<Fiyatliste, FiyatlisteDTO>().ReverseMap();
                CreateMap<FiyatyonetimSablondetay, FiyatyonetimSablondetayDTO>().ReverseMap();
                CreateMap<FiyatyonetimSablon, FiyatyonetimSablonDTO>().ReverseMap();
                CreateMap<FiyatyonetimStokdeger,FiyatyonetimStokdegerDTO>().ReverseMap();

                //Gider

                CreateMap<Giderfi, GiderfiDTO>().ReverseMap();
                CreateMap<GiderfisDetay, GiderfisDetayDTO>().ReverseMap();

                //Kategori

                CreateMap<Kategori, KategoriDTO>().ReverseMap();
                CreateMap<Kategori1, Kategori1DTO>().ReverseMap();

                //Satış

                CreateMap<Sati,SatiDTO>().ReverseMap();
                CreateMap<Satisdetay, SatisdetayDTO>().ReverseMap();
                CreateMap<SatisteklifDetay, SatisteklifDetayDTO>().ReverseMap();
                CreateMap<Satisteklif, SatisteklifDTO>().ReverseMap();

                

                //Sipariş

                CreateMap<Sipari,SipariDTO>().ReverseMap();
                CreateMap<CreateSiparisRequest, Sipari>().ReverseMap();
                CreateMap<DeleteSiparisRequest, Sipari>().ReverseMap();
                CreateMap<UpdateSiparisRequest,Sipari>().ReverseMap();

                CreateMap<SiparisDeger,SiparisDegerDTO>().ReverseMap();
                CreateMap<SiparisDetay,SiparisDetayDTO>().ReverseMap();


                //Stoktanim

                CreateMap<StoktanimAmbalajbirim, StoktanimAmbalajbirimDTO>().ReverseMap();
                CreateMap<StoktanimAmbalajkullanim, StoktanimAmbalajkullanimDTO>().ReverseMap();
                CreateMap<StoktanimBirimcevrim, StoktanimBirimcevrimDTO>().ReverseMap();
                CreateMap<StoktanimDepoadre, StoktanimDepoadreDTO>().ReverseMap();
                CreateMap<StoktanimDepo, StoktanimDepoDTO>().ReverseMap();
                CreateMap<StoktanimEtiketfi, StoktanimEtiketfiDTO>().ReverseMap();
                CreateMap<StoktanimEtiketfisdetay,StoktanimEtiketfisdetayDTO>().ReverseMap();
                CreateMap<StoktanimGrupdetay, StoktanimGrupdetayDTO>().ReverseMap();
                CreateMap<StoktanimGrupdetaygrup,StoktanimGrupdetaygrupDTO>().ReverseMap();
                CreateMap<StoktanimGrup, StoktanimGrupDTO>().ReverseMap();
                CreateMap<StoktanimHizmetkdv, StoktanimHizmetkdvDTO>();
                CreateMap<StoktanimKoddonusumCari,StoktanimKoddonusumCariDTO>().ReverseMap();
                CreateMap<StoktanimKoddonusumDetay,StoktanimKoddonusumDetayDTO>().ReverseMap();
                CreateMap<StoktanimKoddonusum,StoktanimKoddonusumDTO>().ReverseMap();
                CreateMap<StoktanimLisan,StoktanimLisanDTO>().ReverseMap();
                CreateMap<StoktanimPerakendedepartman,StoktanimPerakendedepartmanDTO>().ReverseMap();
                CreateMap<StoktanimRecete, StoktanimReceteDTO>().ReverseMap();
                CreateMap<StoktanimSubedetay, StoktanimSubedetayDTO>().ReverseMap();
                CreateMap<StoktanimTedarikci,StoktanimTedarikciDTO>().ReverseMap();
                CreateMap<StoktanimVaryasyon,StoktanimVaryasyonDTO>().ReverseMap();
                CreateMap<Stokuretimetiketdepartman, StokuretimetiketdepartmanDTO>().ReverseMap();
                CreateMap<Stokuretimetiketdetay,StokuretimetiketdetayDTO>().ReverseMap();
                CreateMap<Stokuretimetiketdizayn,StokuretimetiketdizaynDTO>().ReverseMap();
                CreateMap<Stokuretimetiket,StokuretimetiketDTO>().ReverseMap();
                CreateMap<StokvirmanCiki,StokvirmanCikiDTO>().ReverseMap();
                CreateMap<Stokvirman,StokvirmanDTO>().ReverseMap();
                CreateMap<StokvirmanGiris,StokvirmanGirisDTO>().ReverseMap();
                
                CreateMap<StoktanimBarkod,StoktanimBarkodDTO>().ReverseMap();
                CreateMap<StoktanimBarkod, CreateStokTanimBarkodRequest>().ReverseMap();
                CreateMap<StoktanimBarkod, UpdateStokStanimBarkodRequest>().ReverseMap();
                CreateMap<StoktanimBarkodsablon,StoktanimBarkodSablonDTO>().ReverseMap();
               
                CreateMap<StoktanimBirim,StokTanimBirimDTO>().ReverseMap();

                CreateMap<Stoktanim,StokTanimDTO>().ReverseMap();
                CreateMap<CreateStokTanimRequest, Stoktanim>().ReverseMap();
                CreateMap<UpdateStokTanimRequest, Stoktanim>().ReverseMap();

                //User

                CreateMap<User, UserDTO>().ReverseMap();

            }
        }
    }
}
