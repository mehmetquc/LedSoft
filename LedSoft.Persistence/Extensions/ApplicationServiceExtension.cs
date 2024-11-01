using LedSoft.Application.DTOs;
using LedSoft.Application.DTOs.SiparisAllDTO;
using LedSoft.Application.DTOs.StokTanimAllDTOS;
using LedSoft.Application.ResponseModels;
using LedSoft.Persistence.Contexts;
using LedSoft.Persistence.Features.Cari.Commands;
using LedSoft.Persistence.Features.Fatura.Commands;
using LedSoft.Persistence.Features.Kategori.Query;
using LedSoft.Persistence.Features.Siparis.Commands;
using LedSoft.Persistence.Features.Siparis.Queries;
using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Persistence.Features.Stok.Queries;
using LedSoft.Persistence.Features.User.Commands;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Persistence.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection service)
        {
            service.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            service.AddTransient<IRequestHandler<CreateStokTanimRequest, ServiceResponse<StokTanimDTO>>, CreateStokTanimHandler>();
            service.AddTransient<IRequestHandler<StokTanimAllsDTO, ServiceResponse<string>>, CreateOrUpdateAllStok>();
            service.AddTransient<IRequestHandler<UserLoginRequest, ServiceResponse<UserloginResponseDTO>>, UserLoginHandler>();
            service.AddTransient<IRequestHandler<UpdateStokTanimRequest, ServiceResponse<StokTanimDTO>>, UpdateStokTanimHandler>();
            service.AddTransient<IRequestHandler<GetStokTanimByIdRequest, ServiceResponse<StokTanimDTO>>, GetStokTanimByIdHandeler>();
            service.AddTransient <IRequestHandler<GetallKategoriRequest, ServiceResponse<List<KategoriDTO>>>, GetallKategoriHandler >();
            service.AddTransient<IRequestHandler<GettAllSiparisByCarikodRequest, ServiceResponse<List<SiparisAllsDTO>>>, GetAllSiparisByCariKodHandler>();
            service.AddTransient<IRequestHandler<CreateChtanimRequest, ServiceResponse<string>>, CreateOrUpdateChtanimHandler>();
            service.AddTransient<IRequestHandler<GetAllStokTanimRequest, ServiceResponse<List<StokListDTO>>>, GetAllStokTanimHandler>();
            service.AddTransient<IRequestHandler<CreateFaturaRequest, ServiceResponse<string>>, CreateFaturaHandler>();
            service.AddTransient<IRequestHandler<CreateSiparisRequest, ServiceResponse<SipariDTO>>, CreateSiparisHandler>();
            service.AddTransient<IRequestHandler<UpdateSiparisRequest,ServiceResponse<SipariDTO>>, UpdateSiparisHandler>();
            service.AddTransient<IRequestHandler<DeleteSiparisRequest, ServiceResponse<string>>, DeleteSiparisHandler>();
            service.AddTransient<IRequestHandler<GettAllSiparisByIdRequest, ServiceResponse<SipariDTO>>, GetAllSiparisByIdHandler>();
            service.AddTransient<IRequestHandler<GettAllSiparisRequest, ServiceResponse<List<SiparisListDTO>>>,GettAllSiparisHandler>();
            service.AddScoped<LafSadikContext>();
            return service;
        }
    }
}
