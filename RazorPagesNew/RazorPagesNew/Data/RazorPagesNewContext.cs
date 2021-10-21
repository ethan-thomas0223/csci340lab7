using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesNew.Models;

namespace RazorPagesNew.Data
{
    public class RazorPagesNewContext : DbContext
    {
        public RazorPagesNewContext (DbContextOptions<RazorPagesNewContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesNew.Models.Team> Team { get; set; }
    }
}
