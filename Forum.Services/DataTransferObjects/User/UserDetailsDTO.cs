using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Services.DataTransferObjects.User
{
    public class UserDetailsDTO
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
