using System;
using System.Collections.Generic;
using System.Linq;
using Forum.Services.DataTransferObjects.User;
using Forum.Services.DrivenInterfaces;
using Forum.Services.DriverInterfaces;
using Forum.Services.Models.User;

namespace Forum.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Register(UserCreateDTO user)
        {
            if (user == null)
            {
                throw new ArgumentNullException();
            }

            var userToRegister = new User
            {
                Id = Guid.NewGuid(),
                Username = user.Username,
                Password = user.Password,
                Email = user.Email
            };

            _userRepository.Create(userToRegister);
        }

        public void ChangeUsername(Guid id, string username)
        {
            var userToChangeUserNameTo = _userRepository.FindUser(id);
            userToChangeUserNameTo.Username = username;
            _userRepository.Edit(id, userToChangeUserNameTo);
        }

        public void ChangePassword(Guid id, string oldPassword, string newPassword)
        {
            var userToChangePasswordTo = _userRepository.FindUser(id);
            if (userToChangePasswordTo.Password != oldPassword)
            {
                throw new ArgumentException("Incorect old password!");
            }
            userToChangePasswordTo.Password = newPassword;
            _userRepository.Edit(id, userToChangePasswordTo);
        }

        public UserDetailsDTO FindById(Guid id)
        {
            var user = _userRepository.FindUser(id);

            return new UserDetailsDTO
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email
            };
        }

        public List<UserListDTO> List()
        {
            return _userRepository
                .List()
                .Select(u => new UserListDTO
                {
                    Id = u.Id,
                    Username = u.Username
                })
                .ToList();
        }
    }
}
