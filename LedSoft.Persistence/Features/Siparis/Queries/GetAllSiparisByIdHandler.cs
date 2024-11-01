using Ardalis.GuardClauses;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Azure.Core;
using LedSoft.Application.DTOs;
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

    public class GettAllSiparisByIdRequest:IRequest<ServiceResponse<SipariDTO>>
    {
        public long SiparisId { get; set; }
    }

    public class GetAllSiparisByIdHandler:IRequestHandler<GettAllSiparisByIdRequest,ServiceResponse<SipariDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public GetAllSiparisByIdHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<SipariDTO>> Handle(GettAllSiparisByIdRequest request, CancellationToken cancellationToken)
        {
            var result = await _context.Siparis.AsNoTracking().ProjectTo<SipariDTO>(_mapper.ConfigurationProvider).Where(c => c.Id == request.SiparisId).FirstOrDefaultAsync(cancellationToken);

            Guard.Against.Null(result, message: "Sipariş Bulunamadı!!");
            return new ServiceResponse<SipariDTO>()
            {
                Value = result,
            };
        }
    }
}
