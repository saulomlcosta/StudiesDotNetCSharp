using MediatR;
using SBExCQRSMediatR.Domain.Commands.Responses;

namespace SBExCQRSMediatR.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}