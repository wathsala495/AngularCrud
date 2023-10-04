using codePulse.API.Models.Domain;

namespace codePulse.API.Repositories.Interface
{
    public interface IItemRepository
    {
        Task<Category> GetItemByIdAsync(int id);
    }
}
