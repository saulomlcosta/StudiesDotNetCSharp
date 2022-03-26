using Microsoft.AspNetCore.Mvc;
using SBExCQRSMediatR.Domain.Commands.Requests;
using SBExCQRSMediatR.Domain.Handlers;

namespace SBExCQRSMediatR.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create(
                [FromServices] ICreateCustomerHandler handler,
                [FromBody] CreateCustomerRequest command
            )
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}