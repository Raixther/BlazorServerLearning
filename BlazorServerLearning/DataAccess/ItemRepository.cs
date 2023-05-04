using BlazorServerLearning.Models;

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Internal;

namespace BlazorServerLearning.DataAccess
{
    public class ItemRepository : IItemRepository
    {    
        private readonly IServiceScopeFactory scopeFactory;

        public ItemRepository(
        IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
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
            using (var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ItemDbContext>();
                var result = dbContext.Items.AsEnumerable();
                return result;
            }                
        }

        public Item GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Item Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
