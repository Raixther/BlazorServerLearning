using BlazorServerLearning.Models;

namespace BlazorServerLearning.DataAccess
{
    public interface IItemRepository:IRepository<Item, int>
    {
    }
}
