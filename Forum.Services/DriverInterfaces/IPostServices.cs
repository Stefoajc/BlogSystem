using System;
using System.Collections.Generic;

namespace Forum.Services.DriverInterfaces
{
    public interface IPostServices
    {
        void Create(object postCreateDTO, Guid userId);
        void ChangeTitle(string title, Guid userId);
        void ChangeBody(string body, Guid userId);
        void Delete(Guid id, Guid userId);
        object FindById(Guid id);
        List<object> List();
    }
}