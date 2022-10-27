using System.Data.Entity;

namespace KisiselWebProjesi.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<admin> Admins { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<ikonlar> ikonlars { get; set; }
    }
}