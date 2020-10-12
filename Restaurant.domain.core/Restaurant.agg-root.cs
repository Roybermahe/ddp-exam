using System;
using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public class Restaurant
    {
        private readonly List<IProduct> _allProducts;

        public Restaurant() => _allProducts = new List<IProduct>();

        public string AddIngredient(Ingredient ingredient)
        {
            if (ingredient.Detail.Quantity == 0) return "Se necesita una cantidad mayor a 0";
            if (ProductExist(ingredient.Detail.Id))
            {
                GetProduct(ingredient).GetDetail().Quantity += ingredient.Detail.Quantity;
                return "Se aumento la cantidad de este ingrediente"; 
            }
            _allProducts.Add(ingredient);
            return "Se agrego el ingrediente correctamente";
        }

        public string TakeProduct(int IdProducto, int cantidad)
        {
            _allProducts.Find(t => t.Identification() == IdProducto)?.TakeProduct(cantidad, TODO);
        }
        
        public void AddAllIngredients(IEnumerable<Ingredient> list)
        {
            foreach (var item in list)
            {
                AddIngredient(item);
            }
        }

        private bool ProductExist(int idProducto)
        {
            return _allProducts.FindAll(t => t.Identification() == idProducto).Count > 0;
        }

        private IProduct GetProduct(IProduct product)
        {
            return _allProducts.Find(t => t.Identification() == product.Identification());
        }

        private List<IProduct> GetIngredients()
        {
            return _allProducts.FindAll(t => t is Ingredient);
        }
    }
}