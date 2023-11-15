using Microsoft.AspNet.Identity;
using SimpleTrader.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTrader.Domain.Exeptions;

namespace SimpleTrader.Domain.Services.AuthanticationServices
{
    public class AuthanticationService : IAuthanticationService
    {
        private readonly IAccountService _accountService;
        private readonly IPasswordHasher _passwordHasher;
        public AuthanticationService(IAccountService accountService, IPasswordHasher passwordHasher)
        {
            _accountService=accountService;
            _passwordHasher = passwordHasher;
        }

        public async Task<Account> Login(string username, string password)
        {
            Account storedAccount = await _accountService.GetByUserName(username);
            PasswordVerificationResult passwordResult = _passwordHasher.VerifyHashedPassword(storedAccount.AccountHolder.PasswordHash, password);

            if (passwordResult != PasswordVerificationResult.Success)
            {
                throw new InvalidPasswordExeption(username, password);
            }
            return storedAccount;
        }

        public async Task<RegistrationResult> Register(string email, string username, string password, string confirmPassword)
        {
            RegistrationResult result = RegistrationResult.Success;

            if (password != confirmPassword)
            {
                result = RegistrationResult.Success;
            }

            Account emailAccount = await _accountService.GetByEmail(email);

            if (emailAccount != null)
            {
                result = RegistrationResult.EmailAlreadyExists;
            }

            Account userNameAccount = await _accountService.GetByUserName(email);

            if (userNameAccount != null)
            {
                result = RegistrationResult.UsernameAlreadyExist;
            }

            if (result == RegistrationResult.Success)
            {
                string hashedPassword = _passwordHasher.HashPassword(password);
                User user = new User()
                {
                    Email = email,
                    UserName = username,
                    PasswordHash = hashedPassword,
                    DatedJoined = DateTime.Now
                };

                Account account = new Account()
                {
                    AccountHolder = user,

                };
                await _accountService.Create(account);
            }
            
            return result;
        }
    }
}
