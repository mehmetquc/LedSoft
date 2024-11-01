using AutoMapper;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using MediatR;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Cari.Commands
{
    public class CreateAllChtanimHandler : IRequestHandler<CreateAllChtanimRequest, ServiceResponse<string>>
    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public CreateAllChtanimHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<string>> Handle(CreateAllChtanimRequest request, CancellationToken cancellationToken)
        {
            var db = _mapper.Map<Chtanim>(request.Chtanims);
            if (db != null)
            {
                await _context.AddRangeAsync(db);
                int result = await _context.SaveChangesAsync();
                return new ServiceResponse<string>
                {
                    Value = result > 0 ? "Başarılı" : "Kayıt Başarısız!"
                };
            }
            return new ServiceResponse<string>();


        }
    }
}
