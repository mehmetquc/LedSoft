using LedSoft.Persistence.Features.Cari.Commands;
using LedSoft.Persistence.Features.Fatura.Commands;
using LedSoft.Persistence.Features.Fatura.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LedSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CariController : ControllerBase
    {

        private readonly IMediator _mediator;
        public CariController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("CreateOrUpdate")]
        public async Task<IActionResult> CreateOrUpdateCari(CreateChtanimRequest request, CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(request, cancellationToken));
        }
        
    }
}
