using LedSoft.Application.DTOs;
using LedSoft.Application.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Features.Fatura.Commands
{
    public class CreateFaturaRequest:IRequest<ServiceResponse<string>>
    {
        public List<FaturaDTO> FaturaLists { get; set; } = new List<FaturaDTO>();
        public List<FaturaDetayDTO> faturaDetays { get; set; } = new List<FaturaDetayDTO> { };
        public List<FaturaBarkoddetayDTO> faturaBarkoddetays { get; set; } = new List<FaturaBarkoddetayDTO>();
    }
}
