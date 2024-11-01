using LedSoft.Persistence.Features.Birim.Queries;
using LedSoft.Persistence.Features.Siparis.Commands;
using LedSoft.Persistence.Features.Siparis.Queries;
using LedSoft.Persistence.Features.Stok.Commands;
using LedSoft.Persistence.Features.Stok.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LedSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SiparisController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SiparisController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Create")]
        public async Task<IActionResult> CreateSiparis(CreateSiparisRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateSiparis(UpdateSiparisRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteSiparis(DeleteSiparisRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }

        [HttpGet("GettAllSiparisById")]
        public async Task<IActionResult> GettAllSiparisById(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GettAllSiparisByIdRequest(), cancellationToken));
        }
        [HttpGet("GettAllSiparis")]
        public async Task<IActionResult> GettAllSiparis(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new GettAllSiparisRequest(), cancellationToken));
        }

    }
}
