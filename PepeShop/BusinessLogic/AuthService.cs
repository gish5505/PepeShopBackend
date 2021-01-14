using PepeShop.BusinessLogic.Abstractions;
using PepeShop.DAL;
using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic
{
    public class AuthService : IAuthService
    {
        private readonly PepeShopContext _context;

        public AuthService(PepeShopContext context)
        {
            _context = context;
        }

        public async Task<UserModel> Authenticate(LoginRequest request)
        {

            return new UserModel()
            {
                Id = 1,
                Role = RoleType.Manager,
                Name = "Hans"
                

            
            };
        }

    }
}
