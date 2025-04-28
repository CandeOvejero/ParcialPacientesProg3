using Microsoft.EntityFrameworkCore;
using ParcialPacientesProg3.Models;

namespace HospitalPacientes.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HospitalDB;Trusted_Connection=True;MultipleActiveResultSets=True");
        }
    }
}
