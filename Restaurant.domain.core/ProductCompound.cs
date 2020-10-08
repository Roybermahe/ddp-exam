using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public class ProductCompound: Product
    {
        public int Identify { get; }
        private readonly List<SimpleProduct> _ingredients;
        public ProductCompound(int identify,decimal cost, decimal price, string productName, string type, List<SimpleProduct> ingredients) : base(cost, price, productName, type)
        {
            Identify = identify; 
            _ingredients = ingredients;
        }

        public override decimal CreateProduct(string product = "")
        {
            throw new System.NotImplementedException();
        }
    }
}