using Ardalis.GuardClauses;
using AutoMapper;
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

namespace LedSoft.Persistence.Features.Siparis.Commands
{
    public class UpdateSiparisHandler : IRequestHandler<UpdateSiparisRequest, ServiceResponse<SipariDTO>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public UpdateSiparisHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<SipariDTO>> Handle(UpdateSiparisRequest request, CancellationToken cancellationToken)
        {
            var dbsipari = await _context.Siparis.AsNoTracking().Where(c => c.Id == request.Id).FirstOrDefaultAsync();
            Guard.Against.Null(dbsipari, message: "Sipariş Bulunamadı");
            _mapper.Map(request, dbsipari);
            _context.Siparis.Update(dbsipari);
            int result = await _context.SaveChangesAsync();
            return new ServiceResponse<SipariDTO>()
            {
                Value = _mapper.Map<SipariDTO>(dbsipari)
            };
        }
    }
}
