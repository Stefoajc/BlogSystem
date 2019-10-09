using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Model
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<User> User { get; set; }
    }
}
