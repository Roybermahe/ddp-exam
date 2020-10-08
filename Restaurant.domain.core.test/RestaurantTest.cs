using NUnit.Framework;

namespace Restaurant.domain.core.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddNewIngredient()
        {
            var restaurant = new Restaurant();
            var ingredient = new SimpleProduct(identify: 1, cost: 5000m, price: 1000m, productName: "PAN DE PERRO", type: Restaurant.ForSale, quantity: 12);
            var result = restaurant.AddNewIngredient(ingredient);
            Assert.AreEqual("Se agrego el ingrediente correctamente",result);
        }
        
        [Test]
        public void AddQuantityToIngredientRepeated()
        {
            var restaurant = new Restaurant();
            var ingredient1 = new SimpleProduct(identify: 1, cost: 5000m, price: 1000m, productName: "PAN DE PERRO", type: Restaurant.ForSale, quantity: 12);
            var ingredient2 = new SimpleProduct(identify: 1, cost: 5000m, price: 1000m, productName: "PAN DE PERRO", type: Restaurant.ForUse, quantity: 12);
            restaurant.AddNewIngredient(ingredient1);
            var result = restaurant.AddNewIngredient(ingredient2);
            Assert.AreEqual("Se aumento la cantidad disponible de este producto, hay 24",result);
        }

        [Test]
        public void QuantityIngredientsAvailables()
        {
            var restaurant = new Restaurant();
            var ingredient1 = new SimpleProduct(identify: 1, cost: 5000m, price: 1000m, productName: "PAN DE PERRO", type: Restaurant.ForSale, quantity: 12);
            var ingredient2 = new SimpleProduct(identify: 1, cost: 5000m, price: 1000m, productName: "PAN DE PERRO", type: Restaurant.ForSale, quantity: 12);
            var result = restaurant.AddAllIngredients(new SimpleProduct[2]{
                ingredient1, ingredient2
            });
            Assert.AreEqual("all ingredients added",result);
            Assert.AreEqual(restaurant.CantidadDeIngredientesDisponibles(), 2);
        }
        
        
    }
}