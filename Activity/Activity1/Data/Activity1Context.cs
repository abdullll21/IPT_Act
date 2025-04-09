using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Activity1.Models;

namespace Activity1.Data
{
    public class Activity1Context : DbContext
    {
        public Activity1Context (DbContextOptions<Activity1Context> options)
            : base(options)
        {
        }

        public DbSet<Activity1.Models.Pet> Pet { get; set; } = default!;
    }
}
