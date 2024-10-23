using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VictorSuquilanda_Project2MVC.Models;

namespace VictorSuquilanda_Project2MVC.Data
{
    public class VictorSuquilanda_Project2MVCContext : DbContext
    {
        public VictorSuquilanda_Project2MVCContext (DbContextOptions<VictorSuquilanda_Project2MVCContext> options)
            : base(options)
        {
        }

        public DbSet<VictorSuquilanda_Project2MVC.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<VictorSuquilanda_Project2MVC.Models.Carrera> Carrera { get; set; } = default!;
    }
}
