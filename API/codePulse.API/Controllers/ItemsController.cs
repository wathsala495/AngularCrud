using codePulse.API.Models.Domain;
using codePulse.API.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace codePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public ItemsController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetItemById(int id)
        {
            var item = await _itemRepository.GetItemByIdAsync(id);

            if (item == null)
            {
                return NotFound();
            }

            return item;
        }
    }
}
