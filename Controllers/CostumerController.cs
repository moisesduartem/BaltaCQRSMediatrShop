using BaltaCQRSMediatrShop.Domain.Commands.Handlers;
using BaltaCQRSMediatrShop.Domain.Commands.Requests;
using BaltaCQRSMediatrShop.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BaltaCQRSMediatrShop.Controllers
{
    [Route("v1/costumers")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        [HttpPost]
        public async Task<CreateCostumerResponse> Create([FromServices] IMediator mediator, [FromBody] CreateCostumerRequest command)
        {
            return await mediator.Send(command);
        }
    }
}
