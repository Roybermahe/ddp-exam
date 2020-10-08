using System;
using System.Collections.Generic;

namespace Restaurant.domain.core
{
    public class Restaurant
    {
        public static string ForSale => "tSale";
        public static string ForUse => "tUse";
        private static List<SimpleProduct> _allIngredients;
        private static List<ProductCompound> _allCompoundsSale;

        public Restaurant()
        {
           _allIngredients = new List<SimpleProduct>();
           _allCompoundsSale = new List<ProductCompound>();
        }
        
        public string AddNewIngredient(SimpleProduct product)
        {
            if (IngredientExist(product.Identify))
            {
                GetIngredient(product.Identify).Quantity += product.Quantity;
                return $"Se aumento la cantidad disponible de este producto, hay {GetIngredient(product.Identify).Quantity}";
            }
            _allIngredients.Add(product);
            return "Se agrego el ingrediente correctamente";
        }

        public string AddAllIngredients(SimpleProduct[] list)
        {
            if (list.Length  == 0)
                return "No hay ingredients";
            foreach (var simpleProduct in list)
            {
                AddNewIngredient(simpleProduct);
            }
            return "all ingredients added";
        }
        
        public int CantidadDeIngredientesDisponibles() {
            return _allIngredients.Count;
        }

        private static bool IngredientExist(int id)
        {
            return _allIngredients.FindAll(t => t.Identify == id).Count > 0;
        }

        private SimpleProduct GetIngredient(int id)
        {
            return _allIngredients.Find(t => t.Identify == id);
        }
    }
}