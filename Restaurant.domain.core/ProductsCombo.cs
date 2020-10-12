using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public class ProductsCombo: IProduct
    {
        private ProductDetail Detail { get; set; }
        private readonly List<IProduct> _listIngredients;

        public ProductsCombo(List<IProduct> listIngredients, ProductDetail detail)
        {
            _listIngredients = listIngredients;
            Detail = detail;
        }

        public List<IProduct> GetIngredients()
        {
            return _listIngredients;
        }

        public string TakeProduct(int cantidad, List<IProduct> ingredients)
        {
            _listIngredients.ForEach(delegate(IProduct product)
            {
                ingredients.Find(t => t.Identification() == product.Identification())?.GetDetail().Quantity -
            });
        }

        public string TakeProduct(int quantity, List<IProduct> ingredients)
        {
            throw new System.NotImplementedException();
        }

        public ProductDetail GetDetail()
        {
            return Detail;
        }

        public int Identification()
        {
            return Detail.Id;
        }

        public decimal Price()
        {
            return Detail.Price;
        }

        public decimal Cost()
        {
            _listIngredients.ForEach(delegate(IProduct item)
            {
                Detail.Cost += item.Cost();
            });
            return Detail.Cost;
        }

        public decimal Utility()
        {
            return Price() - Cost();
        }
    }
}