using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picasso.Model
{
    class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
