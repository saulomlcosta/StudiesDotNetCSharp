using System;
using SBExCQRSMediatR.Domain.Commands.Requests;
using SBExCQRSMediatR.Domain.Commands.Responses;

namespace SBExCQRSMediatR.Domain.Handlers
{
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest command)
        {
            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Customer's Name",
                Email = "Customer's Email",
                Date = DateTime.Now
            };
        }
    }
}