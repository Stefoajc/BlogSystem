using System;

namespace Forum.Services.DataTransferObjects.Comment
{
    public class PostCommentDTO
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string UserCreator { get; set; }
    }
}