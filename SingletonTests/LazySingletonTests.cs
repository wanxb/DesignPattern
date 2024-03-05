using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.Tests
{
    [TestClass()]
    public class LazySingletonTests
    {
        [TestMethod]
        public void LazySingleton_InstanceIsNotNull()
        {
            // Arrange
            LazySingleton instance;

            // Act
            instance = LazySingleton.GetInstance();

            // Assert
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void LazySingleton_SameInstanceReturned()
        {
            // Arrange
            LazySingleton instance1, instance2;

            // Act
            instance1 = LazySingleton.GetInstance();
            instance2 = LazySingleton.GetInstance();

            // Assert
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void LazySingleton_GetInfo_PrintsCorrectMessage()
        {
            // Arrange
            LazySingleton instance = LazySingleton.GetInstance();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            instance.GetInfo();
            string output = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual("I am LazySingleton.", output);
        }
    }
}