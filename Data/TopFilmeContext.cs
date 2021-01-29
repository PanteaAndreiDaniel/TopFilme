using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TopFilme.Modele;

namespace TopFilme.Data
{
    public class TopFilmeContext : DbContext
    {
        public TopFilmeContext (DbContextOptions<TopFilmeContext> options)
            : base(options)
        {
        }

        public DbSet<TopFilme.Modele.Film> Film { get; set; }
    }
}
