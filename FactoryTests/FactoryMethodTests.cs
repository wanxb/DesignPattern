using Factory.FactoryMethod;
using Factory.FactoryMethod.Circle;
using Factory.FactoryMethod.Square;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Factory.Tests
{
    [TestClass()]
    public class FactoryMethodTests
    {
        [TestMethod()]
        public void BlockFactorySystem_Circle_Test()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            BlockFactorySystem blockFactorySystem = new BlockFactorySystem();
            Assert.IsNotNull(blockFactorySystem);

            blockFactorySystem.ProduceBlocks(new CircleBlockFactory(), 2);
            var itemInfo = blockFactorySystem.GetBlocks();
            // Act
            string output = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual("Circle Block\r\nCircle Block", output); 
            Assert.IsNotNull(itemInfo); 
            Assert.AreEqual(2, itemInfo.Count); 
        }

        [TestMethod()]
        public void BlockFactorySystem_Square_Test()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            BlockFactorySystem blockFactorySystem = new BlockFactorySystem();
            Assert.IsNotNull(blockFactorySystem);

            blockFactorySystem.ProduceBlocks(new SquareBlockFactory(), 3);
            var itemInfo = blockFactorySystem.GetBlocks();
            // Act
            string output = consoleOutput.ToString().Trim();

            // Assert
            Assert.AreEqual("Square Block\r\nSquare Block\r\nSquare Block", output);
            Assert.IsNotNull(itemInfo);
            Assert.AreEqual(3, itemInfo.Count);
        }
    }
}