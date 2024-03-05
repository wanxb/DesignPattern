using Factory.AbstractFactory;
using Factory.AbstractFactory.Chair;
using Factory.AbstractFactory.Sofa;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FactoryTests
{
    [TestClass()]
    public class AbstractFactoryTests
    {
        [TestMethod()]
        public void FurnitureFactory_Modern_Test()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            IFurnitureFactory factory = new ModernFurnitureFactory();
            Assert.IsNotNull(factory);

            // 根据工厂生产椅子和沙发
            IChair chair = factory.CreateChair();
            ISofa sofa = factory.CreateSofa();

            // Assert
            Assert.IsNotNull(chair);
            Assert.IsNotNull(sofa);

            // 输出家具信息
            chair.ShowInfo();

            // Act
            string output = consoleOutput.ToString().Trim();
            Assert.AreEqual("modern chair", output);
             
            sofa.DisplayInfo();
            output = consoleOutput.ToString().Trim();
            Assert.AreEqual("modern chair\r\nmodern sofa", output); 
        }

        [TestMethod()]
        public void FurnitureFactory_Classical_Test()
        {
            var consoleOutput = new StringWriter();
            Console.SetOut(consoleOutput);

            IFurnitureFactory factory = new ClassicalFurnitureFactory();
            Assert.IsNotNull(factory);

            // 根据工厂生产椅子和沙发
            IChair chair = factory.CreateChair();
            ISofa sofa = factory.CreateSofa();

            // Assert
            Assert.IsNotNull(chair);
            Assert.IsNotNull(sofa);

            // 输出家具信息
            chair.ShowInfo();

            // Act
            string output = consoleOutput.ToString().Trim();
            Assert.AreEqual("classical chair", output);

            sofa.DisplayInfo();
            output = consoleOutput.ToString().Trim();
            Assert.AreEqual("classical chair\r\nclassical sofa", output);
        }
    }
}
