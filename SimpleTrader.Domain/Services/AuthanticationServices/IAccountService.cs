using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTrader.Domain.Models;

namespace SimpleTrader.Domain.Services.AuthanticationServices
{
    public interface IAccountService : IDataService<Account>
    {
        Task<Account> GetByUserName(string username);
        Task<Account> GetByEmail(string email);
    }
}
