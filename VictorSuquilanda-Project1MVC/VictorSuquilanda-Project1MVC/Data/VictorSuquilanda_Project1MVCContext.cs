using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VictorSuquilanda_Project1MVC.Models;

namespace VictorSuquilanda_Project1MVC.Data
{
    public class VictorSuquilanda_Project1MVCContext : DbContext
    {
        public VictorSuquilanda_Project1MVCContext (DbContextOptions<VictorSuquilanda_Project1MVCContext> options)
            : base(options)
        {
        }

        public DbSet<VictorSuquilanda_Project1MVC.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<VictorSuquilanda_Project1MVC.Models.Carrera> Carrera { get; set; } = default!;
    }
}
