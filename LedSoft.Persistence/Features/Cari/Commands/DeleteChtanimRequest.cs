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
    public class DeleteChtanimRequest :IRequest<ServiceResponse<string>>
    {
        public long Id { get; set; }

        public string? Kod { get; set; }

        public string? Isim { get; set; }

        public string? Tip { get; set; }

        public string? Dovizcinsi { get; set; }

        public bool? Aktif { get; set; }

        public int? Subeid { get; set; }
    }
}
