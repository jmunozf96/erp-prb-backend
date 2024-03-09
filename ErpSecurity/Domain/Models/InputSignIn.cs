using ErpSecurity.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErpSecurity.Domain.Models
{
    public class InputSignIn(string Email, string Password)
    {
        public string Email { get; } = Email;
        public string Password { get; } = Password;
    }
}
