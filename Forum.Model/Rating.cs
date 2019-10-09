using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Model
{
    public abstract class Rating
    {
        public Guid Id { get; set; }
        public int Score { get; set; }

        public User User { get; set; }
        public Post Post { get; set; }
    }
}
