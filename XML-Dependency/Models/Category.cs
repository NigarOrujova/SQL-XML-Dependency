namespace XML_Dependency.Models
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
            this.Foods = new HashSet<Food>();
        }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Food> Foods { get; set; }

    }
}
