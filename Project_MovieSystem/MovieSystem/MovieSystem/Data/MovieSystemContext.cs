using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieSystem.Models;

namespace MovieSystem.Models
{
    public class MovieSystemContext : DbContext
    {
        public MovieSystemContext (DbContextOptions<MovieSystemContext> options)
            : base(options)
        {
        }

        public DbSet<MovieSystem.Models.Movie> Movie { get; set; }

        public DbSet<MovieSystem.Models.Actor> Actor { get; set; }

        public DbSet<MovieSystem.Models.Producer> Producer { get; set; }
    }
}
