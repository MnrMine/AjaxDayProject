using Microsoft.EntityFrameworkCore;

namespace AjaxDay.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-HHOE249\\SQLEXPRESS;initial catalog=AjaxDb;integrated Security=true;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
