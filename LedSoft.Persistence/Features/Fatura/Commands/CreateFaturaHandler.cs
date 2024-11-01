using AutoMapper;
using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Fatura.Commands
{
    public class CreateFaturaHandler : IRequestHandler<CreateFaturaRequest, ServiceResponse<string>>
    {
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly LafSadikContext _context;
        public CreateFaturaHandler(IMapper mapper, IConfiguration configuration, LafSadikContext context)
        {
            _mapper = mapper;
            _configuration = configuration;
            _context = context;
        }
        public async Task<ServiceResponse<string>> Handle(CreateFaturaRequest request, CancellationToken cancellationToken)
        {
            bool isDetays = false;
            List<FaturaIdDTO> faturaIdDTOs = new List<FaturaIdDTO>();
            foreach (var item in request.FaturaLists)
            {
                FaturaIdDTO faturaId = new FaturaIdDTO();
                faturaId.OldId = item.Id;
                var fatura = _mapper.Map<LedSoft.Persistence.Fatura>(item);
                fatura.Id = faturaId.NewId;
                fatura.Tip = "F1";
                await _context.Faturas.AddAsync(fatura, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                faturaId.NewId = fatura.Id;
                faturaIdDTOs.Add(faturaId);
            }
            foreach (var item in faturaIdDTOs)
            {
                var faturaDetayList = request.faturaDetays.Where(c => c.Faturaid == item.OldId).ToList();
                var faturaBarkodList = request.faturaBarkoddetays.Where(c => c.Faturaid == item.OldId).ToList();
                foreach (var faturaDetay in faturaDetayList)
                {
                    var faturaDetays = _mapper.Map<LedSoft.Persistence.FaturaDetay>(faturaDetay);
                    faturaDetays.Faturaid = item.NewId;
                    await _context.FaturaDetays.AddAsync(faturaDetays, cancellationToken);
                    await _context.SaveChangesAsync(cancellationToken);

                }
                foreach (var barkod in faturaBarkodList)
                {
                    var faturaBarkod = _mapper.Map<FaturaBarkoddetay>(barkod);
                    faturaBarkod.Faturaid = item.NewId;
                    await _context.FaturaBarkoddetays.AddAsync(faturaBarkod, cancellationToken);
                    await _context.SaveChangesAsync(cancellationToken);
                }
                isDetays = false;

            }
            return new ServiceResponse<string>
            {
                Value = "Success"
            };




        }
    }
}
