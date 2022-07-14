using Economic.Application.Interface;
using Economic.Data.EF;
using Economic.ViewModels.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Economic.Application.Services
{
    public class UserService : IUserService
    {
        private readonly EconomicDbContext _context;
        private readonly IConfiguration _configuration;

        public UserService(EconomicDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<List<UserViewModel>> GetAllAsync()
        {
            var users = await _context.Users.Select(u => new UserViewModel()
            {
                Name = u.Name,
                Address = u.Address,
                Email = u.Email,
                UserName = u.UserName,
            }).ToListAsync();
            return users;
        }
    }
}
