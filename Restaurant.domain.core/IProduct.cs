using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public interface IProduct
    {
        List<IProduct> GetIngredients();
        string TakeProduct(int cantidad, List<IProduct> ingredients);
        ProductDetail GetDetail();
        int Identification();
        decimal Price();
        decimal Cost();
        decimal Utility();
    }
}