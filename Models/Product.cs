namespace ScratchRentMe.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Style { get; set; }
        public string Category { get; set; }

        public Product(int id, string style, string category)
        {
            this.Id = id;
            this.Style = style;
            this.Category = category;
        }
    }
}
