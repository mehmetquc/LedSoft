using AutoMapper;
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

namespace LedSoft.Persistence.Features.Siparis.Commands
{
    public class CreateSiparisHandler : IRequestHandler<CreateSiparisRequest, ServiceResponse<SipariDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public CreateSiparisHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<SipariDTO>> Handle(CreateSiparisRequest request, CancellationToken cancellationToken)
        {
            var dbsipari=await _context.Siparis.AsNoTracking().Where(c=>c.Id==request.Id).FirstOrDefaultAsync();
            if (dbsipari==null)
                throw new Exception("Sipariş Zaten Bulunmakta");

            dbsipari = _mapper.Map<Sipari>(request);
            await _context.Siparis.AddAsync(dbsipari);
            int result = await _context.SaveChangesAsync();

            return new ServiceResponse<SipariDTO>()
            {
                Value = result > 0 ? _mapper.Map<SipariDTO>(dbsipari) : new SipariDTO()
            };

        }
    }
}
