using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using idleGood_WebAPI.Models; 
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using idleGood_WebAPI.Dtos;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Mvc.ApiExplorer;


namespace idleGood_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ItemsController(ApplicationDbContext context)
        {
            _context = context; 
        }

        // GET: api/Items/ItemRecommend
        [HttpGet("ItemRecommend")]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItemRecommend()
        {
            var itemCount = await _context.Item.CountAsync();
            var items = await _context.Item
                .Where(i => i.IsPublic && i.ItemId >= 100 && i.ItemId <= 106)
                .Select(i => new ItemDto
                {
                    ItemId = i.ItemId,
                    SellerId = i.SellerId,
                    ImageUrl = i.ImageUrl,
                    Price = i.Price,
                    Title = i.Title,
                    VideoUrl = i.VideoUrl,
                    AdDescription = i.AdDescription,
                    Description = i.Description,
                    SellerName = i.SellerName,
                    LikesCount = i.LikesCount,
                    SellerIconUrl = i.SellerIconUrl,
                })
                .ToListAsync();
            return Ok(items);
        }

        // GET: api/Items/ItemPopular
        [HttpGet("ItemPopular")]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItemPopular()
        {
            var itemCount = await _context.Item.CountAsync();
            var items = await _context.Item
                .Where(i => i.IsPublic && i.ItemId >= 107 && i.ItemId <= 115)
                .Select(i => new ItemDto
                {
                    ItemId = i.ItemId,
                    SellerId = i.SellerId,
                    ImageUrl = i.ImageUrl,
                    Price = i.Price,
                    Title = i.Title,
                    VideoUrl = i.VideoUrl,
                    AdDescription = i.AdDescription,
                    Description = i.Description,
                    SellerName = i.SellerName,
                    LikesCount = i.LikesCount,
                    SellerIconUrl = i.SellerIconUrl,
                })
                .ToListAsync();
            return Ok(items);
        }


        // GET: api/Items/ItemAll
        [HttpGet("ItemAll")]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetItemAll()
        {
            var items = await _context.Item
                .Where(i => i.IsPublic)
                .Select(i => new ItemDto
                {
                    ItemId = i.ItemId,
                    SellerId = i.SellerId,
                    ImageUrl = i.ImageUrl,
                    Price = i.Price,
                    Title = i.Title,
                    VideoUrl = i.VideoUrl,
                    AdDescription = i.AdDescription,
                    Description = i.Description,
                    SellerName = i.SellerName,
                    LikesCount = i.LikesCount,
                    SellerIconUrl = i.SellerIconUrl,
                })
                .ToListAsync();
            return Ok(items);
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPost("Create")]
        public async Task<ActionResult<ItemDto>> PostItemForSale(ItemCreateDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "User is not logged in." });
            }

            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                return NotFound(new { Message = "User not found." });
            }

            var item = new Item
            {
                Title = model.Title,
                Description = model.Description,
                Price = model.Price,
                ImageUrl = model.ImageUrl,
                VideoUrl = model.VideoUrl,
                SellerId = userId, // Associate the item with the logged in user
                SellerIconUrl = user.UserIconUrl,
                IsPublic = true,
            };

            _context.Item.Add(item);
            await _context.SaveChangesAsync();
           
            var itemDto = new ItemDto
            {
                ItemId = item.ItemId,
                ImageUrl = item.ImageUrl,
                VideoUrl = item.VideoUrl,
                Description = item.Description,
                Price = item.Price,
                Title = item.Title,
                SellerName = user.UserName, // Assuming the user model has a UserName
                LikesCount = 0,
                SellerIconUrl = user.UserIconUrl, 
            };

            return CreatedAtAction("GetItemAll", new { id = item.ItemId }, itemDto);
        }

        [HttpGet("MyItems")]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public async Task<ActionResult<IEnumerable<ItemDto>>> GetMyItemsForSale()
        {
            // 获取当前登录用户的ID
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { Message = "User is not logged in." });
            }
            
            // 查询数据库，找到所有属于该用户的商品
            var items = await _context.Item
                .Where(i => i.SellerId == userId && i.IsPublic) // 确保只返回公开出售的商品
                .Select(i => new ItemDto
                {
                    ItemId = i.ItemId,
                    SellerId = i.SellerId,
                    ImageUrl = i.ImageUrl,
                    VideoUrl = i.VideoUrl,
                    Description = i.Description,
                    AdDescription = i.AdDescription,
                    Price = i.Price,
                    Title = i.Title,
                    SellerName = i.Seller.UserName, // 假设Seller是User对象的导航属性
                    LikesCount = i.LikesCount,
                    SellerIconUrl = i.SellerIconUrl,

                })

                .ToListAsync();

            return Ok(items);
        }
        // PUT: api/Items/UpdateDescription/5
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpPut("UpdateDescription/{id}")]
        public async Task<IActionResult> UpdateItemDescription(int id, [FromBody] ItemUpdateDto itemUpdateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound(new { Message = "Item not found." });
            }

            // Append the new description to the existing one
            item.Description = $"{item.Description} {itemUpdateDto.AdDescription}".Trim();

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Item.Remove(item);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemId == id);
        }

        // GET: api/Items/Search?query=keyword
        [HttpGet("Search")]
        public async Task<ActionResult<IEnumerable<ItemDto>>> SearchItems(string query)
        {
            var items = await _context.Item
                .Where(i => i.Title.Contains(query) ||
                            i.ItemTags.Any(it => it.Tag.Name.Contains(query)))
                .Select(i => new ItemDto
                {
                    ItemId = i.ItemId,
                    ImageUrl = i.ImageUrl,
                    Price = i.Price,
                    Title = i.Title,
                    SellerName = i.SellerName,
                    LikesCount = i.LikesCount
                })
                .ToListAsync();

            return Ok(items);
        }

    }
}
