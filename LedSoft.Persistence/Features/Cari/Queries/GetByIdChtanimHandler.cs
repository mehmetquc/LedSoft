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
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Cari.Queries
{
    public class GetByIdChtanimRequest:IRequest<ServiceResponse<ChtanimDTO>>
    {
        public int Id { get; set; }
    }
    public class GetByIdChtanimHandler : IRequestHandler<GetByIdChtanimRequest, ServiceResponse<ChtanimDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public GetByIdChtanimHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<ChtanimDTO>> Handle(GetByIdChtanimRequest request, CancellationToken cancellationToken)
        {
            var dbChtanim = await _context.Chtanims.ProjectTo<ChtanimDTO>(_mapper.ConfigurationProvider).FirstOrDefaultAsync(c => c.Id == request.Id);
            if (dbChtanim != null)
                return new ServiceResponse<ChtanimDTO>();
            return new ServiceResponse<ChtanimDTO>
            {
                Value=dbChtanim
            };
        }
    }
}
