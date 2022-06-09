using Microsoft.AspNetCore.Mvc;
using NetCoreAngularApp.Application.Interfaces;
using NetCoreAngularApp.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAngularApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get([FromServices] IUserService userService)
        {
            return Ok(userService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromServices] IUserService userService, UserViewModel userViewModel)
        {
            return Ok(userService.Post(userViewModel));
        }
    }
}
