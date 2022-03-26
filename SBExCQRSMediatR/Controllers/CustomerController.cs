using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using SBExCQRSMediatR.Domain.Commands.Requests;
using SBExCQRSMediatR.Domain.Commands.Responses;

namespace SBExCQRSMediatR.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create(
                [FromServices] IMediator mediator,
                [FromBody] CreateCustomerRequest command
            )
        {
            return mediator.Send(command);
        }
    }
}