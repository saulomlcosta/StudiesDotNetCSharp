using SBExCQRSMediatR.Domain.Commands.Requests;
using SBExCQRSMediatR.Domain.Commands.Responses;

namespace SBExCQRSMediatR.Domain.Handlers
{
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest command);
    }
}