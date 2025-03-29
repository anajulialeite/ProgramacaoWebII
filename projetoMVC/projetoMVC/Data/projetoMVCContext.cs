using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using projetoMVC.Models;

namespace projetoMVC.Data
{
    public class projetoMVCContext : DbContext
    {
        public projetoMVCContext (DbContextOptions<projetoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<projetoMVC.Models.Movie> Movie { get; set; } = default!;
    }
}
