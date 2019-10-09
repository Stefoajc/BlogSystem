using System;
using System.Collections.Generic;
using Forum.Services.DataTransferObjects.User;
using Forum.Services.Models;
using Forum.Services.Models.User;

namespace Forum.Services.DriverInterfaces
{
    public interface IUserServices
    {
        void Register(UserCreateDTO user);
        void ChangeUsername(Guid id, string username);
        void ChangePassword(Guid id, string oldPassword, string newPassword);
        UserDetailsDTO FindById(Guid id);
        List<UserListDTO> List();
    }
}
