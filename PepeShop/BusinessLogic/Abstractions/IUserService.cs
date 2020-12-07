using PepeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeShop.BusinessLogic.Abstractions
{
    public interface IUserService 
    {
        Task<List<UserListItem>> GetUserList();

        Task<UserModel> GetUser(int id);

        Task AddUser(UserModel user);

        Task EditUser(UserModel user);
    }
}
