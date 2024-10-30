using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuquilandaVictor_PruebaProgreso1.Models;

namespace SuquilandaVictor_PruebaProgreso1.Data
{
    public class SuquilandaVictor_PruebaProgreso1Context : DbContext
    {
        public SuquilandaVictor_PruebaProgreso1Context (DbContextOptions<SuquilandaVictor_PruebaProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<SuquilandaVictor_PruebaProgreso1.Models.VSuquilanda> VSuquilanda { get; set; } = default!;
        public DbSet<SuquilandaVictor_PruebaProgreso1.Models.Celular> Celular { get; set; } = default!;
    }
}
