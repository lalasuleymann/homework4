using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.ViewModels
{
    public class AccountViewModel
    {
        public string Username { get; set; }
        public string Fullname { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
