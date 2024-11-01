using AutoMapper;
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
    public class GettAllSiparisByCarikodRequest : IRequest<ServiceResponse<List<SiparisAllsDTO>>>
    {
        public string CariKod { get; set; }
    }
    public class GetAllSiparisByCariKodHandler : IRequestHandler<GettAllSiparisByCarikodRequest, ServiceResponse<List<SiparisAllsDTO>>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GetAllSiparisByCariKodHandler(LafSadikContext Context, IMapper mapper, IConfiguration configuration)
        {
            _context = Context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<List<SiparisAllsDTO>>> Handle(GettAllSiparisByCarikodRequest request, CancellationToken cancellationToken)
        {
            var cariId = await _context.Chtanims
    .AsNoTracking()
    .FirstOrDefaultAsync(c => c.Kod == request.CariKod, cancellationToken);
            if (cariId == null)
                throw new Exception("cari bulunamadı");
            var groupedSiparis = await _context.Siparis
            .AsNoTracking()
            .Where(c => c.Chid == cariId.Id)
            .Join(_context.SiparisDetays.AsNoTracking(),
                siparis => siparis.Id,
                siparisdetay => siparisdetay.Siparisid,
                (siparis, siparisdetay) => new
                {
                    siparis,
                    siparisdetay
                })
            .Join(_context.SiparisDegers.AsNoTracking(),
                siparis => siparis.siparis.Id,
                siparisDeger => siparisDeger.Siparisid,
                (siparis, siparisDeger) => new
                {
                    siparis.siparis,
                    siparis.siparisdetay,
                    siparisDeger
                })
            .GroupBy(s => s.siparis.Id) // Group by siparis.Id
            .Select(group => new SiparisAllsDTO
            {
                SiparisId = group.Key,
                SparisGetAll = group.Select(g => new SparisGetAllDTO
                {
                    SiparisDegers = g.siparisDeger,
                    Siparies = g.siparis,
                    SiparisDetays = g.siparisdetay
                }).ToList()
            })
            .ToListAsync(cancellationToken);
            if (groupedSiparis == null)
                return new ServiceResponse<List<SiparisAllsDTO>>();
            return new ServiceResponse<List<SiparisAllsDTO>>
            {
                Value = groupedSiparis
            };
        }
    }
}
