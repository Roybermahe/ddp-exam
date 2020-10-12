using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public class DirectSale: IProduct
    {
        public ProductDetail Detail { get; private set; }

        public DirectSale(ProductDetail detail)
        {
            Detail = detail;
        }
        
        public List<IProduct> GetIngredients()
        {
            return null;
        }

        public string TakeProduct(int cantidad, IEnumerable<IProduct> ingredients)
        {
            throw new System.NotImplementedException();
        }

        public string TakeProduct(int quantity, List<IProduct> ingredients)
        {
            Detail.Quantity -= quantity;
            return $"Se retiraron {quantity} {Detail.Name} son $ {(Detail.Price * quantity)}";
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