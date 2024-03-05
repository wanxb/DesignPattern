using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.Tests
{
    [TestClass()]
    public class ShoppingCartManagerTests
    {
        [TestMethod()]
        public void ShoppingCartManager_Test()
        {
            ShoppingCartManager cart = ShoppingCartManager.GetInstance();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            cart.AddToCart("Apple", 3);
            cart.AddToCart("Banana", 2);
            cart.AddToCart("Orange", 5);

            cart.ViewCart();

            string output = consoleOutput.ToString().Trim();

            // Assert
            StringAssert.Contains(output, "Apple 3");
            StringAssert.Contains(output, "Banana 2");
            StringAssert.Contains(output, "Orange 5");
        }
    }
}