using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace Api.Infrastructure.Data
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {

        }

        //Models
        public DbSet<User> Users { get; set; }
        
    }
}