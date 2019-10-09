using System;
using System.Collections.Generic;
using Forum.Services.Models;
using Forum.Services.Models.User;

namespace Forum.Services.DrivenInterfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        void Delete(Guid id);
        void Edit(Guid id, User user);
        User FindUser(Guid id);
        List<User> List();
    }
}