using System;
using System.Collections.Generic;
using Forum.Services.DataTransferObjects.Comment;

namespace Forum.Services.DataTransferObjects.Post
{
    public class PostDetailsDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string CreatorUsername { get; set; }
        public List<PostCommentDTO> Comments { get; set; }
        public double AvgRating { get; set; }
    }
}