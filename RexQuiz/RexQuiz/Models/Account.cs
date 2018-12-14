using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RexQuiz.Models
{
    public class Account
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
