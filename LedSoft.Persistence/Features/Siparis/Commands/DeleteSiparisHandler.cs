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

namespace LedSoft.Persistence.Features.Siparis.Commands
{

    public class DeleteSiparisRequest : IRequest<ServiceResponse<string>>
    {
        public long SiparisId { get; set; }
    }
    public class DeleteSiparisHandler : IRequestHandler<DeleteSiparisRequest, ServiceResponse<string>>

    {
        private readonly LafSadikContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public DeleteSiparisHandler(LafSadikContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<ServiceResponse<string>> Handle(DeleteSiparisRequest request, CancellationToken cancellationToken)
        {
           

           
                // Siparişin olup olmadığını kontrol et
                var siparis = await _context.Siparis.FindAsync(request.SiparisId,cancellationToken);

            if (siparis == null)
                throw new Exception("Siparis Bulunamadı");

               
                _context.Siparis.Remove(siparis);

                // Değişiklikleri kaydet
               int result= await _context.SaveChangesAsync(cancellationToken); // cancellationToken burada kullanılıyor


      

            return new ServiceResponse<string> { Value=result>0?"Succes":"Eror..!"};
        }
    }
}
