using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Base.Models;
using Microsoft.AspNetCore.Identity;

namespace Base.Data
{
    // Esta clase representa el contexto de la base de datos para la aplicación.
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
        // Constructor que sirve para configuración para el contexto de la base de datos.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
        // Propiedad que representa la tabla `Usuarios` en la base de datos.
        // Está vinculada al modelo `Usuario` definido en la aplicación.
        public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Categoria>Categoria {  get; set; }
		public DbSet<Articulo> Articulo { get; set; }
		public DbSet<Carrito> Carrito { get; set; }
		public DbSet<CarritoArticulo> carritoArticulos { get; set; }		
	}
}
