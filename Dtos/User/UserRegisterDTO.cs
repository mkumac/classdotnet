using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace classdotnet.Dtos.User
{
    public class UserRegisterDTO
    {
        public String Username { get; set; } = string.Empty;
        public String Password { get; set; } = string.Empty;
    }
}