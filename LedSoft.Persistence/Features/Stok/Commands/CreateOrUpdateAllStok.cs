using AutoMapper;
using Azure.Core;
using LedSoft.Application.DTOs.StokTanimAllDTOS;
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

namespace LedSoft.Persistence.Features.Stok.Commands
{
    public class CreateOrUpdateAllStok : IRequestHandler<StokTanimAllsDTO, ServiceResponse<string>>
    {

        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public CreateOrUpdateAllStok(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<string>> Handle(StokTanimAllsDTO request, CancellationToken cancellationToken)
        {
            foreach (var StokTanim in request.StokTanimAllDTOs)
            {
              

                var dbstokTanim = await _context.Stoktanims.AsNoTracking().FirstOrDefaultAsync(c => c.Kod == StokTanim.StokTanims.Kod,cancellationToken);
                if (dbstokTanim!=null)
                {

                    _context.Stoktanims.Update(StokTanim.StokTanims);
                  
                }
                else
                {
                  await  _context.Stoktanims.AddAsync(StokTanim.StokTanims,cancellationToken);
            
                }
                var dbStoktanimbarkod = await _context.StoktanimBarkods.AsNoTracking().FirstOrDefaultAsync(c => c.Barkod == StokTanim.StokTanimBarkods.Barkod, cancellationToken);
                if (dbStoktanimbarkod!=null)
                {
                    _context.StoktanimBarkods.Update(StokTanim.StokTanimBarkods);
                }
                else
                {
                  await  _context.StoktanimBarkods.AddAsync(StokTanim.StokTanimBarkods, cancellationToken);
                }
                var dbStoktanimVaryasyon = await _context.StoktanimVaryasyons.AsNoTracking().FirstOrDefaultAsync(c => c.Id == StokTanim.StokTanimVaryasyons.Id,cancellationToken);
                if (dbStoktanimVaryasyon != null)
                {
                    _context.StoktanimVaryasyons.Update(StokTanim.StokTanimVaryasyons);
                }
                else
                {
                   await _context.StoktanimVaryasyons.AddAsync(StokTanim.StokTanimVaryasyons, cancellationToken);
                }
                var dbFiyatListe= await _context.Fiyatlistes.AsNoTracking().FirstOrDefaultAsync(c => c.Id == StokTanim.Fiyatlistes.Id, cancellationToken);
                if (dbFiyatListe != null)
                {
                    _context.Fiyatlistes.Update(StokTanim.Fiyatlistes);
                }
                else
                {
                    await _context.Fiyatlistes.AddAsync(StokTanim.Fiyatlistes, cancellationToken);
                }
                var dbFiyatListeDetay = await _context.FiyatlisteDetays.AsNoTracking().FirstOrDefaultAsync(c => c.Id == StokTanim.FiyatlisteDetays.Id,cancellationToken);
                if (dbFiyatListeDetay != null)
                {
                    _context.FiyatlisteDetays.Update(StokTanim.FiyatlisteDetays);
                }
                else
                {
                    await _context.FiyatlisteDetays.AddAsync(StokTanim.FiyatlisteDetays,cancellationToken);
                }
                await _context.SaveChangesAsync(cancellationToken);
            }
            return new ServiceResponse<string> { Value="Başarılı"};
            
        }
    }
}
