using BlazorServerLearning.Models;

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;

namespace BlazorServerLearning.DataAccess
{
    public class ItemRepository : IItemRepository
    {
        private readonly DbContextFactory<ItemDbContext> dbContextFactory;

        public ItemRepository(DbContextFactory<ItemDbContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }
        public Item Create(Item entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Item> GetAll()
        {
            var dbContext = dbContextFactory.CreateDbContext();
            var result = dbContext.Items.AsEnumerable();
            return result;
        }

        public Item GetById(int id)
        {
            var dbContext = dbContextFactory.CreateDbContext();
            var result = dbContext.Items.FirstOrDefault(i => i.Id == id);
            return result;
        }

        public Item Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
