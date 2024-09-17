using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Services.Interface
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
    }
}