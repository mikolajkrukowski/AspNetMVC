using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetMVC.Models;

namespace AspNetMVC.Data
{
    public class AspNetMVCContext : DbContext
    {
        public AspNetMVCContext (DbContextOptions<AspNetMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AspNetMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
