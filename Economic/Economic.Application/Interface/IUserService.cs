using Economic.ViewModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Interface
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllAsync();
    }
}
