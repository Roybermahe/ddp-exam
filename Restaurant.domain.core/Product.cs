namespace Restaurant.domain.core
{
    public abstract class Product
    {
        public decimal Cost { get; set; }
        public decimal Price { get; private set;}
        public string ProductName {get; private set; }
        public string Type { get; private set; }

        protected Product(decimal cost, decimal price, string productName, string type)
        {
            Cost = cost;
            Price = price;
            ProductName = productName;
            Type = type;
        }

        abstract public decimal CreateProduct(string product = "");
    }
}