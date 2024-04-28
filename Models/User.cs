using Microsoft.AspNetCore.Identity;


namespace idleGood_WebAPI.Models
{
    public class User : IdentityUser
    {
        public string ?UserIconUrl { get; set; }
        public ICollection<Item> ?ItemsForSale { get; set; }

        public ICollection<TransactionHistory> ?Purchases { get; set; }
        public ICollection<TransactionHistory> ?Sales { get; set; }
        public string ?Address { get; set; }
        public string ?SelfIntro { get; set; }

    }
}
