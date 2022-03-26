using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SBExCQRSMediatR.Domain.Commands.Requests;
using SBExCQRSMediatR.Domain.Commands.Responses;

namespace SBExCQRSMediatR.Domain.Handlers
{
    public class CreateCustomerHandler :
        IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Customer's Name",
                Email = "Customer's Email",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}