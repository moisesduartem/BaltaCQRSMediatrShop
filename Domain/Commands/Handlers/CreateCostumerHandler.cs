using BaltaCQRSMediatrShop.Domain.Commands.Requests;
using BaltaCQRSMediatrShop.Domain.Commands.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace BaltaCQRSMediatrShop.Domain.Commands.Handlers
{
    public class CreateCostumerHandler : IRequestHandler<CreateCostumerRequest, CreateCostumerResponse>
    {
        public Task<CreateCostumerResponse> Handle(CreateCostumerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCostumerResponse
            {
                Id = Guid.NewGuid(),
                Name = "André Baltieri",
                Email = "andre@balta.io",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
