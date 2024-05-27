using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agri_Energy.Model;

namespace Agri_Energy.Data
{
    public class Agri_EnergyContext : DbContext
    {
        public Agri_EnergyContext (DbContextOptions<Agri_EnergyContext> options)
            : base(options)
        {
        }

        public DbSet<Agri_Energy.Model.Product> Product { get; set; } = default!;
        public DbSet<Agri_Energy.Model.Farmer> Farmer { get; set; } = default!;
    }
}
