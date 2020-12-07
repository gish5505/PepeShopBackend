using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic.Abstractions
{
    public interface IAuthService
    {
        Task<UserModel> Authenticate(LoginRequest request);
    }
}
