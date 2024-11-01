using Ardalis.GuardClauses;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Fatura.Queries
{

    public class GetAllFaturaByIdRequest:IRequest<ServiceResponse<FaturaDTO>>
    {
        public long FaturaId { get; set; }
    }
    public class GetAllFaturaByIdHandler:IRequestHandler<GetAllFaturaByIdRequest, ServiceResponse<FaturaDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GetAllFaturaByIdHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<FaturaDTO>> Handle(GetAllFaturaByIdRequest request, CancellationToken cancellationToken)
        {
            var result = await _context.Faturas.AsNoTracking().ProjectTo<FaturaDTO>(_mapper.ConfigurationProvider).Where(c => c.Id == request.FaturaId).FirstOrDefaultAsync(cancellationToken);

            Guard.Against.Null(result, message: "Fatura Bulunamadı!!");
            return new ServiceResponse<FaturaDTO>()
            {
                Value = result,
            };
        }
    }
}
