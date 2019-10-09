using System;
using System.Collections.Generic;
using Forum.Services.DataTransferObjects.Post;
using Forum.Services.DrivenInterfaces;
using Forum.Services.DriverInterfaces;

namespace Forum.Services
{
    public class PostServicesL: IPostServices
    {
        private readonly IPostRepository _postRepository;

        public PostServicesL(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void Create(PostCreateDTO postCreateDTO, Guid userId)
        {
            throw new NotImplementedException();
        }

        public void ChangeTitle(string title, Guid postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public void ChangeBody(string body, Guid postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid postId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public PostDetailsDTO FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<PostListDTO> List()
        {
            throw new NotImplementedException();
        }
    }
}