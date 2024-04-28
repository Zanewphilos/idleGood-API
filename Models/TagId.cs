namespace idleGood_WebAPI.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public ICollection<ItemTag> ItemTags { get; set; }
    }
}
