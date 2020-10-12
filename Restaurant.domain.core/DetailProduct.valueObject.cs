namespace Restaurant.domain.core
{
    public class ProductDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public ProductDetail(int id,string nameProduct, decimal cost = 0, int quantity = 0, decimal price = 0)
        {
            Id = id;
            Name = nameProduct;
            Cost = cost;
            Quantity = quantity;
            Price = price;
        }
    }
}