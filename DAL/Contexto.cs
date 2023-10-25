using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Contexto : DbContext
    {
        // Los DbSet definen las operaciones básicas contra cada
        // entidad de base de datos (CRUD).
        // En los DbSet se definen colecciones de las clases definidas
        // en Entidades.cs, lo que nos daría las entidades de la base de datos.
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Prueba> Pruebas { get; set; }

        // Se define un constructor que nos permita generar el contexto
        // como servicio desde el contenedor de servicios de la sesión https
        // de usuario.
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        // Aseguramos el uso de Ids autoincrementales.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }
    }
}