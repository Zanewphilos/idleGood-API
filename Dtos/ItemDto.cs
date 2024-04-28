namespace idleGood_WebAPI.Dtos
{
    public class ItemDto
    {
        public int ItemId { get; set; }
        public string SellerId { get; set; }
        public List<string> ?ImageUrl { get; set; }

        public List<string> ?VideoUrl { get; set; }

        public string ?Description { get; set; }

        public string AdDescription { get; set; }
        public float Price { get; set; }
        public string Title { get; set; }
        public string SellerName { get; set; }
        public int LikesCount { get; set; }
        // SellerIconUrl 可能会从关联的 UserDto 中获取
        public string SellerIconUrl { get; set; }

    }
}
