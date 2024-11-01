using AutoMapper;
using AutoMapper.QueryableExtensions;
using LedSoft.Application.DTOs;
using LedSoft.Application.DTOs.SiparisAllDTO;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Siparis.Queries
{
    public class GettAllSiparisRequest : IRequest<ServiceResponse<List<SiparisListDTO>>>
    {

    }
    public class GettAllSiparisHandler : IRequestHandler<GettAllSiparisRequest, ServiceResponse<List<SiparisListDTO>>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GettAllSiparisHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<List<SiparisListDTO>>> Handle(GettAllSiparisRequest request, CancellationToken cancellationToken)
        {
            var dbsiparis = await _context.Siparis.AsNoTracking().Join(_context.Chtanims, siparis => siparis.Chid, cari => cari.Id, (siparis, cari) => new
            {
         siparis,
         cari
            }).ToListAsync(cancellationToken);
            var result = dbsiparis.Select(c => new SiparisListDTO
            {
                Id = c.siparis.Id,
                Tarih = c.siparis.Tarih,
                Saat = c.siparis.Saat,
                Evrakno = c.siparis.Evrakno,
                Aciklama = c.siparis.Aciklama,
                Detayaciklama = c.siparis.Detayaciklama,
                CariIsim = c.cari.Isim,
                CariKod = c.cari.Kod,
                Chid = c.cari.Id,
                Kdvtoplam = _context.SiparisDegers.Where(x => x.Siparisid == c.siparis.Id).Sum(x => x.Kdvtoplam),
                Maltoplam = _context.SiparisDegers.Where(x => x.Siparisid == c.siparis.Id).Sum(x => x.Maltoplam),
                Tutar = _context.SiparisDegers.Where(x => x.Siparisid == c.siparis.Id).Sum(x => x.Tutar)
            }).ToList();
            if (result != null)
                return new ServiceResponse<List<SiparisListDTO>>();
            return new ServiceResponse<List<SiparisListDTO>>()
            {
                Value = result!
            };

        }
    }
}
