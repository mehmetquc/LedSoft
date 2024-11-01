using AutoMapper;
using LedSoft.Application.CustomExceptions;
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

namespace LedSoft.Persistence.Features.Cari.Commands
{
    public class CreateOrUpdateChtanimHandler : IRequestHandler<CreateChtanimRequest, ServiceResponse<string>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public CreateOrUpdateChtanimHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }
        public async Task<ServiceResponse<string>> Handle(CreateChtanimRequest request, CancellationToken cancellationToken)
        {
            var cari = await _context.Chtanims.AsNoTracking().FirstOrDefaultAsync(c => c.Kod == request.Kod, cancellationToken);
            if (cari.Id == null)
            {
                var dbChtanim = _mapper.Map<Chtanim>(request);
                await _context.Chtanims.AddAsync(dbChtanim, cancellationToken);
                var result = await _context.SaveChangesAsync(cancellationToken);

                return new ServiceResponse<string>
                {
                    Value = result > 0 ? "Kayıt Başarılı" : "Kayıt Başarısız"
                };

            }
            cari= _mapper.Map(request, cari);
            _context.Chtanims.Update(cari);
            var results = await _context.SaveChangesAsync(cancellationToken);

            return new ServiceResponse<string>
            {
                Value = results > 0 ? "Güncelleme Başarılı" : "Güncelleme Başarısız"
            };
        }
    }
}
