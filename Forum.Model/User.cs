using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }


        public Role Role { get; set; }
        public List<Post> Posts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Rating> RaiList { get; set; }
    }
}
