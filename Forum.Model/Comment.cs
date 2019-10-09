using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Model
{
    public class Comment
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public User User { get; set; }
        public Post Post { get; set; }
    }
}
