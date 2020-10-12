using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public class Prepared: IProduct
    {
        public ProductDetail Product { get; set; }
        private readonly List<IProduct> _listIngredients;

        public Prepared(List<IProduct> listIngredients, ProductDetail product)
        {
            _listIngredients = listIngredients;
            Product = product;
        }

        public List<IProduct> GetIngredients()
        {
            return _listIngredients;
        }

        public string TakeProduct(int cantidad, List<IProduct> ingredients)
        {
            throw new System.NotImplementedException();
        }

        public ProductDetail GetDetail()
        {
            return Product;
        }

        public int Identification()
        {
            return Product.Id;
        }

        public decimal Price()
        {
            return Product.Price;
        }

        public decimal Cost()
        {
            _listIngredients.ForEach(delegate(IProduct item)
            {
                Product.Cost += item.Cost();
            });
            return Product.Cost;
        }

        public decimal Utility()
        {
            return Price() - Cost();
        }
    }
}