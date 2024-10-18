using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VictorSuquilanda_Taller1.Models;

namespace VictorSuquilanda_Taller1.Data
{
    public class VictorSuquilanda_Taller1Context : DbContext
    {
        public VictorSuquilanda_Taller1Context (DbContextOptions<VictorSuquilanda_Taller1Context> options)
            : base(options)
        {
        }

        public DbSet<VictorSuquilanda_Taller1.Models.Equipo> Equipo { get; set; } = default!;
        public DbSet<VictorSuquilanda_Taller1.Models.Estadio> Estadio { get; set; } = default!;
        public DbSet<VictorSuquilanda_Taller1.Models.Jugador> Jugador { get; set; } = default!;
    }
}
