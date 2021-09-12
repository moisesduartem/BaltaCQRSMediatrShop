using BaltaCQRSMediatrShop.Domain.Commands.Requests;
using BaltaCQRSMediatrShop.Domain.Commands.Responses;
using System;

namespace BaltaCQRSMediatrShop.Domain.Commands.Handlers
{
    public class CreateCostumerHandler : ICreateCostumerHandler
    {
        public CreateCostumerResponse Handle(CreateCostumerRequest request)
        {
            return new CreateCostumerResponse {
                Id = Guid.NewGuid(),
                Name = "André Baltieri",
                Email = "andre@balta.io",
                Date = DateTime.Now
            };
        }
    }
}
