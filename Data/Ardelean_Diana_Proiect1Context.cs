using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ardelean_Diana_Proiect1.Models;

namespace Ardelean_Diana_Proiect1.Data
{
    public class Ardelean_Diana_Proiect1Context : DbContext
    {
        public Ardelean_Diana_Proiect1Context (DbContextOptions<Ardelean_Diana_Proiect1Context> options)
            : base(options)
        {
        }

        public DbSet<Ardelean_Diana_Proiect1.Models.Plancs> Plancs { get; set; }
    }
}
