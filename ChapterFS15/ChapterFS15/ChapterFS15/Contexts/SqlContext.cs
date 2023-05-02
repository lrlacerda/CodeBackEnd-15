using ChapterFS15.Models;
using Microsoft.EntityFrameworkCore;

namespace ChapterFS15.Contexts
{
    public class SqlContext : DbContext
    {

        public SqlContext() { }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        protected override void
        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source = LAPTOP-LUCAS\\SQLEXPRESS; initial catalog = Chapter; user id = sa; password = password");
                //optionsBuilder.UseSqlServer("Data Source = LAPTOP-LUCAS\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true; TrustServerCertificate=True");
                optionsBuilder.UseSqlServer("Data Source = LAPTOP-LUCAS\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }

        public DbSet<Livro> Livros { get; set; }     
        public DbSet<Usuario> Usuarios { get; set; }        
        
             
    }
}
