using System;
using System.Collections.Generic;
using Forum.Services.DataTransferObjects.Post;

namespace Forum.Services.DriverInterfaces
{
    public interface IPostServices
    {
        void Create(PostCreateDTO postCreateDTO, Guid userId);
        void ChangeTitle(string title, Guid postId, Guid userId);
        void ChangeBody(string body, Guid postId, Guid userId);
        void Delete(Guid postId, Guid userId);
        PostDetailsDTO FindById(Guid id);
        List<PostListDTO> List();
    }
}