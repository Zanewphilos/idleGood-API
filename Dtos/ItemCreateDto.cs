namespace idleGood_WebAPI.Dtos
{
    public class ItemCreateDto
    {
        
        public string ?Title { get; set; }
        public string ?Description { get; set; }
        public float Price { get; set; }

        // 如果需要，可以添加其他相关属性
        // 例如，如果每个商品有多张图片，你可能会有一个图片URL列表
        public List<string> ?ImageUrl { get; set; }

        public List<string> ?VideoUrl { get; set; }

        public DateTime? ReleaseDate { get; set; }

        
        
    }
}
