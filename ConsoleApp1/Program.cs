using System;
using SimpleTrader.EntityFramework.Services;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            userService.Create(new User { UserName = "Test", Email = "ahufnj@list.ru", PasswordHash = "123456", DatedJoined = DateTime.Now}).Wait();
            Console.WriteLine(userService.GetAll().Result.Count());
        }
    }
}