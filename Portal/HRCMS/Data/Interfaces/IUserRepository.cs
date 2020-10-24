using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRCMS.ViewModels;

namespace HRCMS.Data
{
    public interface IUserRepository
    {
        Task<User> GetUserAsync(string userId);
    }
}
