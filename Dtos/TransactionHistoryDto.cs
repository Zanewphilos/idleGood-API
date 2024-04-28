namespace idleGood_WebAPI.Dtos
{
    public class TransactionHistoryDto
    {
        public int TransactionId { get; set; }
        
        public List<string>? ItemUrl { get; set; }

        public string ?BuyerName { get; set; }

        public string ? BuyerId { get; set; }
        public string ?SellerName { get; set; }

        public string ? SellerId { get; set; }

        public string ?TransactionStatus { get; set; }
        public DateTime TransactionDate { get; set; }
    }

}
