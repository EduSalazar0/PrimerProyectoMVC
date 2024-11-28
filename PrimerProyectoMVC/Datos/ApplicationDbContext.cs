using Microsoft.EntityFrameworkCore;
using PrimerProyectoMVC.Models;

namespace PrimerProyectoMVC.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 

        }

        //Agregar los modelos aqui

        public DbSet<Contacto> Contacto { get; set; }
    }
}
