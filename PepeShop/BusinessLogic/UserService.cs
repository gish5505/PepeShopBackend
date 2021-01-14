using PepeShop.BusinessLogic.Abstractions;
using PepeShop.DAL;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace PepeShop.BusinessLogic
{
    public class UserService : IUserService
    {
        private readonly PepeShopContext _context;

        public UserService(PepeShopContext context)
        {
            _context = context;
        }

        public async Task AddUser(UserModel user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task EditUser(UserModel user)
        {
            _context.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<UserListItem>> GetUserList()
        {
            var result = await _context.Users
                .OrderBy(u => u.Id)
                .Select(u => new UserListItem()
                {
                    Id = u.Id,
                    Name = u.Name,
                    Address = u.Address,
                    Code = u.Code,
                    Discount = u.Discount
                })
                .ToListAsync();
            return result;
        }

        public async Task<UserModel> GetUser(int id)
        {
            var result = await _context.Users
                .Include(u => u.Basket)                    
                    .ThenInclude(x => x.Product)
                .FirstOrDefaultAsync(u => u.Id == id);

            return result;
        }
    }
}
