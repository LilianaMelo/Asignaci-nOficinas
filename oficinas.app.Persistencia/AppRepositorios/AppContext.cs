using Microsoft.EntityFrameworkCore;
using oficinas.app.Dominio;

namespace oficinas.app.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> Personas {get; set;}
        public DbSet <Asesor> Asesores {get; set;}
        public DbSet <EstadoSalud> Covid1 {get; set;}
        public DbSet <Gobernador> Gobernadores {get;set;}
        public DbSet <Oficina> Oficinas {get; set;}
        public DbSet <Proveedor> Proveedores {get;set;}
        public DbSet <Secretario> Secretarios {get; set;}
        public DbSet <Sede> Sedes {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// conexion con la bd
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=oficinas");
            }
        }
    }
}