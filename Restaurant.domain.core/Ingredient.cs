using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public class Ingredient: IProduct
    {
        public ProductDetail Detail { get; set; }

        public Ingredient(ProductDetail detail)
        {
            Detail = detail;
        }

        public List<IProduct> GetIngredients()
        {
            return null;
        }

        public string TakeProduct(int cantidad, List<IProduct> ingredients)
        {
            return "";
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
            return Detail.Cost;
        }

        public decimal Utility()
        {
            return Price() - Cost();
        }
    }
}