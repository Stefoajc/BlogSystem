using System;
using System.Collections.Generic;

namespace Forum.Services.DrivenInterfaces
{
    public interface IPostRepository
    {
        void Create(object postCreateDTO);
        void Edit(object postEditDTO);
        void Delete(Guid id);
        object FindById(Guid id);
        List<object> List();

    }
}