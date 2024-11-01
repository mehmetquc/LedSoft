using Ardalis.GuardClauses;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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

namespace LedSoft.Persistence.Features.Cari.Queries
{
    public class GetAllChtanimRequest:IRequest<ServiceResponse<List<ChtanimDTO>>>
    {

    }
    public class GetAllChtanimHandler : IRequestHandler<GetAllChtanimRequest, ServiceResponse<List<ChtanimDTO>>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public GetAllChtanimHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {

            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<List<ChtanimDTO>>> Handle(GetAllChtanimRequest request, CancellationToken cancellationToken)
        {
            var dbChtanims=await _context.Chtanims.AsNoTracking().ProjectTo<ChtanimDTO>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            if (dbChtanims == null)
                return new ServiceResponse<List<ChtanimDTO>>();
            return new ServiceResponse<List<ChtanimDTO>>
            {
                Value = dbChtanims
            };
        }
    }
}
