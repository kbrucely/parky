using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parkyapi.Models
{
    public class AuthenticationModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
