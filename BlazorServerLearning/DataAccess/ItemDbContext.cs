using BlazorServerLearning.Models;
using Microsoft.EntityFrameworkCore;


namespace BlazorServerLearning.DataAccess
{
    public class ItemDbContext : DbContext
    {
        public ItemDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } 



    }
}
