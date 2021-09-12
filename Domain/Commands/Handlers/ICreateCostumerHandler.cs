using BaltaCQRSMediatrShop.Domain.Commands.Requests;
using BaltaCQRSMediatrShop.Domain.Commands.Responses;

namespace BaltaCQRSMediatrShop.Domain.Commands.Handlers
{
    public interface ICreateCostumerHandler
    {
        public CreateCostumerResponse Handle(CreateCostumerRequest request);
    }
}
