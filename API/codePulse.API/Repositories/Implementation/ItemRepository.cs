using codePulse.API.Data;
using codePulse.API.Models.Domain;
using codePulse.API.Repositories.Interface;

namespace codePulse.API.Repositories.Implementation
{

    public class ItemRepository : IItemRepository

    {
        private readonly ApplicationDbContext dbContext;
        public ItemRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Category> GetItemByIdAsync(int id)
        {
            return await dbContext.Categories.FindAsync(id);
           
        }
    }

}
