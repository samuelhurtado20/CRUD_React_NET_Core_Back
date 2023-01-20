using CRUD_React_NET_Core_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_React_NET_Core_Back.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Managers> Managers { get; set; }
    }
}
