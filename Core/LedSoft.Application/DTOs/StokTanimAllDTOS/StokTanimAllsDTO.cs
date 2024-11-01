using LedSoft.Application.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs.StokTanimAllDTOS
{
    public class StokTanimAllsDTO : IRequest<ServiceResponse<string>>
    {
        public List<StokTanimAllDTO> StokTanimAllDTOs { get; set; } = new List<StokTanimAllDTO>();
    }
}
