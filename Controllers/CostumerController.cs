using BaltaCQRSMediatrShop.Domain.Commands.Handlers;
using BaltaCQRSMediatrShop.Domain.Commands.Requests;
using BaltaCQRSMediatrShop.Domain.Commands.Responses;
using Microsoft.AspNetCore.Mvc;

namespace BaltaCQRSMediatrShop.Controllers
{
    [Route("v1/costumers")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        [HttpPost]
        public CreateCostumerResponse Create([FromServices] ICreateCostumerHandler handler, [FromBody] CreateCostumerRequest command)
        {
            return handler.Handle(command);
        }
    }
}
