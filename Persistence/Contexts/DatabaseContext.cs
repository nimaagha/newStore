using Application.Interfaces.Contexts;
using Domain.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Contexts
{
    public class DatabaseContext:DbContext,IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        
    }
}
