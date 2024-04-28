using System.ComponentModel.DataAnnotations.Schema;

namespace idleGood_WebAPI.Models
{
    public class Item
    {

            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int ItemId { get; set; }

            public bool IsPublic { get; set; }
            public List<string>? ImageUrl { get; set; }
            public List<string>? VideoUrl { get; set; }
            public string ?Description { get; set; }
            public float Price { get; set; }
            public string ?Title { get; set; }
            public string ?SellerName { get; set; }
            public string ?SellerId { get; set; }
            public string ?SellerIconUrl { get; set; }
            public int LikesCount { get; set; }
            public User ?Seller { get; set; }

            public string ?AdDescription { get; set; }

            public ICollection<TransactionHistory> ?TransactionHistory { get; set; }
            public ICollection<ItemTag> ?ItemTags { get; set; }

    }
}
