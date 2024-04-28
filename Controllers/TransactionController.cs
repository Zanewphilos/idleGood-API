using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using idleGood_WebAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using idleGood_WebAPI.Dtos;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace idleGood_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TransactionController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<User> _userManager;

        public TransactionController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: api/Transaction
        [HttpGet("GetUserHistory")]
        public async Task<ActionResult<IEnumerable<TransactionHistoryDto>>> GetUserTransactions()
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            // 获取与当前登录用户相关的交易记录，并投影到 TransactionHistoryDto
            var transactions = await _context.TransactionHistory
                .Where(t => t.BuyerId == userId || t.SellerId == userId)
                .Include(t => t.Item)
                .Select(t => new TransactionHistoryDto
                {
                    TransactionId = t.TransactionId, 
                    ItemUrl = t.ItemUrl, 
                    BuyerName = t.BuyerName, 
                    BuyerId = t.BuyerId,
                    SellerName = t.SellerName, 
                    SellerId = t.SellerId,
                    TransactionStatus = t.Status, 
                    TransactionDate = t.TransactionDate 
                })
                .ToListAsync();

            return transactions;
        }

        // POST: api/Transaction
        [HttpPost("Create")]
        public async Task<ActionResult<TransactionHistory>> PostTransaction(TransactionCreateDto model)
        {
            try
            {
                var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

                // 假设当前登录用户为买家
                var buyer = await _context.Users.FindAsync(userId);
                if (buyer == null)
                {
                    return NotFound(new { Message = "Buyer not found." });
                }

                // 从数据库中获取与 model.ItemId 相匹配的 Item 实体
                var item = await _context.Item.FindAsync(model.ItemId);
                if (item == null)
                {
                    return NotFound(new { Message = "Item not found." });
                }


                // 假设 Item 实体中有一个 SellerId 属性指向卖家
                var seller = await _context.Users.FindAsync(item.SellerId);
                if (seller == null)
                {
                    return NotFound(new { Message = "Seller not found." });
                }

                if (userId == item.SellerId)
                {
                    return BadRequest(new { Message = "You cannot purchase your own item." });
                }
                // dont show this item in the list of items for sale
                item.IsPublic = false;
                _context.Entry(item).State = EntityState.Modified;

                var transaction = new TransactionHistory
                {

                    ItemId = model.ItemId,
                    ItemUrl = item.ImageUrl, // 假设 Item 实体中有 ImageUrl 属性
                    BuyerId = userId,
                    BuyerName = buyer.UserName, // 假设 User 实体中有 UserName 属性
                    SellerId = item.SellerId, // 从商品信息获取卖家ID
                    SellerName = seller.UserName,
                    Status = "In Progress",
                    TransactionDate = DateTime.UtcNow, // 设置交易时间为当前时间
                };

                _context.TransactionHistory.Add(transaction);
                await _context.SaveChangesAsync();

                var transactionDto = new TransactionHistoryDto
                {
                    TransactionId = transaction.TransactionId,
                    ItemUrl =  transaction.ItemUrl, // 或者直接 `ItemUrl = transaction.ItemUrl` 如果你调整了Dto定义
                    BuyerName = transaction.BuyerName,
                    BuyerId = transaction.BuyerId,
                    SellerName = transaction.SellerName,
                    SellerId = transaction.SellerId,
                    TransactionStatus = transaction.Status,
                    TransactionDate = transaction.TransactionDate,
                };

                return CreatedAtAction("GetUserTransactions", new { id = transaction.TransactionId }, transactionDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = $"Internal server error: {ex.Message}" });
            }
            }

        [HttpPut("Status/{id}")]
        public async Task<IActionResult> UpdateTransactionStatus(int id, [FromBody] TransactionStatusUpdateDto model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var transaction = await _context.TransactionHistory.FirstOrDefaultAsync(t => t.TransactionId == id && (t.BuyerId == userId || t.SellerId == userId));

            if (transaction == null)
            {
                return NotFound(new { Message = "Transaction not found." });
            }

       
            transaction.Status = model.Status;

            _context.Entry(transaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransactionExists(id))
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

        private bool TransactionExists(int id)
        {
            return _context.TransactionHistory.Any(e => e.TransactionId == id);
        }
        // DELETE: api/Transaction/5
        [HttpDelete("Delete{id}")]
        public async Task<IActionResult> DeleteUserTransaction(int id)
        {
            var userId = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var transaction = await _context.TransactionHistory
                .FirstOrDefaultAsync(t => t.TransactionId == id && (t.BuyerId == userId || t.SellerId == userId));

            if (transaction == null)
            {
                return NotFound();
            }

            _context.TransactionHistory.Remove(transaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}