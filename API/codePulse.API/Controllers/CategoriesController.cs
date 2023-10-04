using codePulse.API.Data;
using codePulse.API.Models.Domain;
using codePulse.API.Models.DTO;
using codePulse.API.Repositories.Implementation;
using codePulse.API.Repositories.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace codePulse.API.Controllers
{
    //http://localhost:xxxx/api/categories
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
         private readonly ICategoryRepository categoryRepository;              
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
          }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreatecategoryrequestDto request)
        {
            //Map DTO to Domain Model
            var category = new Category
            {
                Name = request.Name,
                UrlHandle = request.UrlHandle,
            };
            await categoryRepository.CreateAsync(category);
           // await dbContext.Categories.AddAsync(category);
           // await dbContext.SaveChangesAsync();

            //Domain model to DTO
            var response = new CategoryDto
            {
                Id = category.Id,
                Name = category.Name,
                UrlHandle = category.UrlHandle

            };

            return Ok();
        }
        
    }
}

