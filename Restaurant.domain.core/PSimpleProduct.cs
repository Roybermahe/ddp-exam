namespace Restaurant.domain.core
{
    public class SimpleProduct: Product
    {
        public int Identify { get; }
        public int Quantity { get; internal set; }

        public SimpleProduct(int identify, decimal cost, decimal price, string productName, string type, int quantity) : base(cost, price, productName, type)
        {
            Identify = identify;
            Quantity = quantity;
        }

        public override decimal CreateProduct(string product = "")
        {
            throw new System.NotImplementedException();
        }
    }
}