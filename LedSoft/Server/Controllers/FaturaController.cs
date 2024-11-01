using LedSoft.Persistence.Features.Fatura.Commands;
using LedSoft.Persistence.Features.Fatura.Queries;
using LedSoft.Persistence.Features.Siparis.Commands;
using LedSoft.Persistence.Features.Siparis.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LedSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class FaturaController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FaturaController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("Create")]
        public async Task<IActionResult> CreateFatura(CreateFaturaRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
        [HttpGet("GetFaturas")]
        public async Task<IActionResult> GetFaturas(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GetAllFaturaByIdRequest(), cancellationToken));
        }


    }

}
