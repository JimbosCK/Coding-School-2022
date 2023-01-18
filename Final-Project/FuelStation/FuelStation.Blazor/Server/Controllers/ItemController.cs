
using FuelStation.Blazor.Shared.ViewModels;
using FuelStation.EF.Repositories;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;

        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListViewModel>> Get()
        {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemListViewModel
            {
                ID = x.ID,
                Code = x.Code,
                Description = x.Description,
                ItemType = (ItemTypeEnum)x.ItemType,
                Price = x.Price,
                Cost = x.Cost
            });
        }

        [HttpGet("{id}")]
        public async Task<ItemListViewModel?> Get(Guid id)
        {
            ItemListViewModel item = new();
            try
            {
                if (id != Guid.Empty)
                {
                    var oldItem = await _itemRepo.GetByIdAsync(id);
                    if (oldItem is null) return null;

                    item.ID = oldItem.ID;
                    item.Code = oldItem.Code;
                    item.Description = oldItem.Description;
                    item.ItemType = (ItemTypeEnum)oldItem.ItemType;
                    item.Cost = oldItem.Cost;
                    item.Price = oldItem.Price;
                }
                return item;
            }
            catch (Exception e)
            {
                return null;
            }

        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<ItemListViewModel>> Delete(Guid id)
        {
            try
            {
                var itemToDelete = await _itemRepo.GetByIdAsync(id);

                if (itemToDelete is null) return NotFound($"Item with Id = {id} not found");

                await _itemRepo.DeleteAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error deleting data: " + e.ToString());
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post(ItemListViewModel item)
        {
            try
            {
                var newItem = new Item()
                {
                    Code = item.Code,
                    Description = item.Description,
                    ItemType = (ItemTypeEnum)item.ItemType,
                    Price = item.Price,
                    Cost = item.Cost
                };

                await _itemRepo.CreateAsync(newItem);
                return Ok();
            }
            catch (Exception e)
            {
                if (e is Microsoft.Data.SqlClient.SqlException)
                {
                    return StatusCode(StatusCodes.Status422UnprocessableEntity,
                        "The request was well-formed but was unable to be followed due to semantic errors. 'Item.Code' might already exist in database.");
                }
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemListViewModel item)
        {
            try
            {
                var itemToUpdate = await _itemRepo.GetByIdAsync(item.ID);

                if (itemToUpdate is null) return NotFound($"Item with Id = {item.ID} not found");

                await _itemRepo.UpdateAsync(item.ID, new Item()
                {
                    Description = item.Description,
                    Code = item.Code,
                    ItemType = (ItemTypeEnum)item.ItemType,
                    Price = item.Price,
                    Cost = item.Cost

                });

                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error processing data: " + e.ToString());
            }

        }
    }
}
