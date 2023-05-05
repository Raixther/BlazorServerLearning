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
            using (var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ItemDbContext>();
                dbContext.Items.Add(entity);
                dbContext.SaveChanges();
                return entity;
            }
        }

        public bool DeleteById(int id)
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ItemDbContext>();
                var item = dbContext.Items.FirstOrDefault(i=>i.Id==id);
                if (item is null)  return false;            
                dbContext.Items.Remove(item); 
                dbContext.SaveChanges();
                return true;         
            }
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

        public Item GetById(int id)//null
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<ItemDbContext>();
                var result = dbContext.Items.FirstOrDefault(i=>i.Id==id);
                return result;
            }
        }

        public Item Update(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
