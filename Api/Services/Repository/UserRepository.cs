using Api.Infrastructure.Data;
using Api.Models;
using Api.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Api.Services.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly BaseContext _context;
        public UserRepository(BaseContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }
    }
}