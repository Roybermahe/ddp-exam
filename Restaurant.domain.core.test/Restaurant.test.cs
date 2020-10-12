using System.Collections.Generic;
using  NUnit.Framework;
namespace Restaurant.domain.core.test
{
    public class RestaurantTest
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [Test]
        public void AddNewIngredient()
        {
            var restaurant = new Restaurant();
            var detail = new ProductDetail(id: 1,nameProduct: "Salchicha",cost: 1000m,quantity: 1);
            var result = restaurant.AddIngredient(new Ingredient(detail));
            Assert.AreEqual("Se agrego el ingrediente correctamente",result);
        }
        
        [Test]
        public void AddNewIngredientWithZeroQuantity()
        {
            var restaurant = new Restaurant();
            var detail = new ProductDetail(id: 1,nameProduct: "Salchicha",cost: 1000m,quantity: 0);
            var result = restaurant.AddIngredient(new Ingredient(detail));
            Assert.AreEqual("Se necesita una cantidad mayor a 0",result);
        }
        
        [Test]
        public void AddNewProductSales()
        {
            var restaurant = new Restaurant();
            restaurant.AddAllIngredients(GenerateDataIngredients());
            // product direct sale
            var detailDirect = new ProductDetail(id: 1,nameProduct: "Gaseosa Litro",cost: 2000m,quantity: 20, price: 5000m);
            var productDirec = new DirectSale(detailDirect);
            // products prepared
            var detailP1 =  new ProductDetail(id: 7,nameProduct: "perro sencillo",cost: 1000m); 
            
            
            
        }

        private static IEnumerable<Ingredient> GenerateDataIngredients()
        {
            var listIngredients = new List<Ingredient>();
            var detail1 = new ProductDetail(id: 2, nameProduct: "Salchicha", cost: 1000m, quantity: 20);
            var detail2 = new ProductDetail(id: 3,nameProduct: "Pan de perro",cost: 1000m,quantity: 20);
            var detail3 = new ProductDetail(id: 4,nameProduct: "Lamina de queso",cost: 1000m,quantity: 20);
            var detail4 = new ProductDetail(id: 5,nameProduct: "Pan de perro extragrande",cost: 1000m,quantity: 20);
            var detail5 = new ProductDetail(id: 6,nameProduct: "Salchicha ranchera",cost: 1000m,quantity: 20);
            listIngredients.Add(new Ingredient(detail1));
            listIngredients.Add(new Ingredient(detail2));
            listIngredients.Add(new Ingredient(detail3));
            listIngredients.Add(new Ingredient(detail4));
            listIngredients.Add(new Ingredient(detail5));
            return listIngredients;
        }
    }
}