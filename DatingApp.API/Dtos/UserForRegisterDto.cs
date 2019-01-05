using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "You must specify password between 6 and 20")]
        public string Password { get; set; }
    }
}
