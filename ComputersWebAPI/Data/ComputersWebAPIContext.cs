using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComputersWebAPI.Models;

namespace ComputersWebAPI.Data
{
    public class ComputersWebAPIContext : DbContext
    {
        public ComputersWebAPIContext (DbContextOptions<ComputersWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ComputersWebAPI.Models.Computer> Computer { get; set; }
    }
}
