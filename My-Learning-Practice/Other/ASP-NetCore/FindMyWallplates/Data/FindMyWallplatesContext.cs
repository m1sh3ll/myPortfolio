using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FindMyWallplates.Models;

namespace FindMyWallplates.Data
{
    public class FindMyWallplatesContext : DbContext
    {
        public FindMyWallplatesContext (DbContextOptions<FindMyWallplatesContext> options)
            : base(options)
        {
        }

        public DbSet<FindMyWallplates.Models.Wallplates> Wallplates { get; set; } = default!;
    }
}
