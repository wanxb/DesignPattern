using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Singleton.Tests
{
    [TestClass()]
    public class EagerSingletonTests
    {
        [TestMethod]
        public void EagerSingleton_InstanceIsNotNull()
        {
            // Arrange
            EagerSingleton instance;

            // Act
            instance = EagerSingleton.GetInstance();

            // Assert
            Assert.IsNotNull(instance);
        }

        [TestMethod]
        public void EagerSingleton_SameInstanceReturned()
        {
            // Arrange
            EagerSingleton instance1, instance2;

            // Act
            instance1 = EagerSingleton.GetInstance();
            instance2 = EagerSingleton.GetInstance();

            // Assert
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void EagerSingleton_GetInfo_PrintsCorrectMessage()
        {
            // Arrange
            EagerSingleton instance = EagerSingleton.GetInstance();
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            // Act
            instance.GetInfo();
            string output = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual("I am EagerSingleton.", output);
        }
    }
}