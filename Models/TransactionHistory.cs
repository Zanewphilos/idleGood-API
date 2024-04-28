using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace idleGood_WebAPI.Models
{
    public class TransactionHistory
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int TransactionId { get; set; }
        public int ItemId { get; set; }
        public List<string>? ItemUrl { get; set; }
        public string ?BuyerId { get; set; }
        public string ?BuyerName { get; set; }
        public string ?SellerId { get; set; }
        public string ?SellerName { get; set; }
        public string Status { get; set; }
        public DateTime TransactionDate { get; set; }


        public Item ?Item { get; set; }
        public User ?Buyer { get; set; }
        public User ?Seller { get; set; } // 卖家的外键关联
    }
}
