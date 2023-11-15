using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore;
using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.Domain.Services.AuthanticationServices;
using SimpleTrader.EntityFramework.Services.Common;

namespace SimpleTrader.EntityFramework.Services
{
    public class AccountDataService : IAccountService
    {

        private readonly SimpleTraderDbContextFactory _contextFactory;
        private readonly NonQueryDataService<Account> _nonQueryDataService;
        public AccountDataService(SimpleTraderDbContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
            _nonQueryDataService = new NonQueryDataService<Account>(contextFactory);
        }

        public async Task<Account> Create(Account entity)
        {
            return await _nonQueryDataService.Create(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await _nonQueryDataService.Delete(id);
        }

        public async Task<Account> Get(int id)
        {
            using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
            {
                Account entity = await context.Accounts
                    .Include(a => a.AccountHolder)
                    .Include(a=>a.AssetTransactions)
                    .FirstOrDefaultAsync(e => e.Id == id);
                return entity;
            }
        }

        public async Task<IEnumerable<Account>> GetAll()
        {
            using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
            {
                IEnumerable<Account> entities = await context.Accounts
                    .Include(a=>a.AccountHolder)
                    .Include(a => a.AssetTransactions)
                    .ToListAsync();
                return entities;
            }
        }

        public async Task<Account> GetByEmail(string email)
        {
            using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.Accounts
                    .Include(a => a.AccountHolder)
                    .Include(a => a.AssetTransactions)
                    .FirstOrDefaultAsync(a => a.AccountHolder.Email == email);
            }
        }

        public async Task<Account> GetByUserName(string username)
        {
            using (SimpleTraderDbContext context = _contextFactory.CreateDbContext())
            {
                return await context.Accounts
                    .Include(a => a.AccountHolder)
                    .Include(a => a.AssetTransactions)
                    .FirstOrDefaultAsync(a => a.AccountHolder.UserName == username);
            }
        }

        public async Task<Account> Update(int id, Account entity)
        {
            return await _nonQueryDataService.Update(id, entity);
        }
    }
}
