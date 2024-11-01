using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Cari.Commands
{
    public class CreateAllChtanimRequest:IRequest<ServiceResponse<string>>
    {
        public List<ChtanimDTO> Chtanims { get; set; }
    }
}
