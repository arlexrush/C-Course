using System;
using System.Collections.Generic;

#nullable disable

namespace User.API.Models
{
    public partial class Users
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
    }
}
