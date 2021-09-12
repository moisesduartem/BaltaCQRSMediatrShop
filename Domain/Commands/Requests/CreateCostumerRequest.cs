using BaltaCQRSMediatrShop.Domain.Commands.Responses;
using MediatR;

namespace BaltaCQRSMediatrShop.Domain.Commands.Requests
{
    public class CreateCostumerRequest : IRequest<CreateCostumerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
