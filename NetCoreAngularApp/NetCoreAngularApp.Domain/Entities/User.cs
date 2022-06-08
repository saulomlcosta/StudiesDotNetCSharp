using System;
using System.Collections.Generic;
using System.Text;
using NetCoreAngularApp.Domain.Models;

namespace NetCoreAngularApp.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
