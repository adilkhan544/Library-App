using Library_App.Models;
using Microsoft.EntityFrameworkCore;
namespace Library_App.Data

{
    public class ApplicationDbContext : DbContext
    {
      public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
       public DbSet<LibraryItem> libraryItems { get; set; }
    }   
}
