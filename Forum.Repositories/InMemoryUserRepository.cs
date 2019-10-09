using System;
using System.Collections.Generic;
using System.Linq;
using Forum.Services.DrivenInterfaces;
using Forum.Services.Exceptions;
using Forum.Services.Models;
using Forum.Services.Models.User;

namespace Forum.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        public List<Model.User> Users { get; set; } = new List<Model.User>();

        public void Create(User user)
        {
            Users.Add(new Model.User
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Password = user.Password
            });
        }

        public void Delete(Guid id)
        {
            var userToRemove = Users.FirstOrDefault(u => u.Id == id);
            Users.Remove(userToRemove);
        }

        public void Edit(Guid id, User user)
        {
            var userToEdit = Users
                .FirstOrDefault(u => u.Id == id) ?? throw new UserNotFoundException();
            userToEdit.Username = user.Username;
        }

        public User FindUser(Guid id)
        {
            return Users
                .Select(user => new User
                {
                    Id = user.Id,
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email
                })
                .FirstOrDefault(u => u.Id == id) ?? throw new UserNotFoundException();            
        }

        public List<User> List()
        {
            return Users
                .Select(user => new User
                {
                    Id = user.Id,
                    Username = user.Username,
                    Password = user.Password,
                    Email = user.Email
                })
                .ToList();
        }
    }
}