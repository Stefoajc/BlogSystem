using System;
using Forum.Repositories;
using Forum.Services;
using Forum.Services.DataTransferObjects.User;
using Forum.Services.DriverInterfaces;
using Forum.Services.Models.User;

namespace NetIT.PracticalOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserServices userServices = new UserServices(new InMemoryUserRepository());

            userServices.Register(new UserCreateDTO
            {
                Username = "Stefan",
                Password = "stefan",
                Email = "stefo123@abv.bg"
            });

            var users = userServices.List();

            foreach (var user in users)
            {
                Print(user);
            }

            Console.WriteLine("Enter the user Id for which you want additional information:");
            var userId = Console.ReadLine();
            if (string.IsNullOrEmpty(userId)) return;
            var foundUser = userServices.FindById(Guid.Parse(userId));

            Print(foundUser);
        }



        public static void Print(UserListDTO user)
        {
            Console.WriteLine($"Id: {user.Id} , Username: {user.Username}");
        }

        public static void Print(UserDetailsDTO user)
        {
            Console.WriteLine($"Id: {user.Id} , Username: {user.Username} , Email: {user.Email}");
        }
    }
}
