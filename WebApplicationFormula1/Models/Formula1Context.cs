using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationFormula1.Models
{
    public class Formula1Context : DbContext
    {
        public Formula1Context(DbContextOptions<Formula1Context> options)
            : base(options)
        {
        }

        public DbSet<Monoplaza> Monoplazas { get; set; }
    }
}
