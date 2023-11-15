using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTrader.Domain.Models;

namespace SimpleTrader.Domain.Services.AuthanticationServices
{
    public enum RegistrationResult
    {
        Success,
        PasswordDoNotMutch,
        EmailAlreadyExists,
        UsernameAlreadyExist
    }

    public interface IAuthanticationService
    {
        Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword);
        Task<Account> Login(string username, string password);
    }
}
