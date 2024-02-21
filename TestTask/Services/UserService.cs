using Microsoft.EntityFrameworkCore;
using TestTask.Data;
using TestTask.Models;
using TestTask.Services.Interfaces;

namespace TestTask.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext _context)
        {
                this._context = _context;
        }
        public async Task<User> GetUser()
        {
            return await this._context.Users.FirstOrDefaultAsync(x=> x.Status == Enums.UserStatus.Inactive);
        }

        public async Task<List<User>> GetUsers()
        {
            return await this._context.Users.ToListAsync();
        }
    }
}
