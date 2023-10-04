using codePulse.API.Data;
using codePulse.API.Models.Domain;
using codePulse.API.Repositories.Implementation;

namespace codePulse.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
       
        
        Task<Category>CreateAsync(Category category);
    }
}
