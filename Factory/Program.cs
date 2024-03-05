using Factory.AbstractFactory;
using Factory.AbstractFactory.Chair;
using Factory.AbstractFactory.Sofa;
using Factory.FactoryMethod;
using Factory.FactoryMethod.Circle;
using Factory.FactoryMethod.Square;

namespace Factory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FactoryMethodTest();
            AbstractFactoryTest();
        }

        private static void FactoryMethodTest()
        {
            BlockFactorySystem blockFactorySystem = new BlockFactorySystem();
            Console.WriteLine("请输入生产次数:");
            string productionCount = Console.ReadLine();
            if (int.TryParse(productionCount, out int count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("请输入生产类型和数量:");
                    var input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input) || input.Split(" ").Length != 2)
                    {
                        break;
                    }
                    string[] productionInfo = input.Split(" ");
                    string blockType = productionInfo[0];
                    int blockQuantity = 0;
                    if (int.TryParse(productionInfo[1], out int quantity))
                    {
                        blockQuantity = quantity;
                    }
                    else
                    {
                        Console.WriteLine("数量输入有误.");
                    };

                    if (blockType.Equals("Circle"))
                    {
                        blockFactorySystem.ProduceBlocks(new CircleBlockFactory(), blockQuantity);
                    }
                    else if (blockType.Equals("Square"))
                    {
                        blockFactorySystem.ProduceBlocks(new SquareBlockFactory(), blockQuantity);
                    }
                }
            }
            else
            {
                Console.WriteLine("次数输入有误.");
            }
        }

        private static void AbstractFactoryTest()
        {
            Console.WriteLine("请输入订单数量:");
            string productionCount = Console.ReadLine();
            if (int.TryParse(productionCount, out int count))
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("请输入家具类型:");
                    var furnitureType = Console.ReadLine();
                    if (string.IsNullOrEmpty(furnitureType))
                    {
                        break;
                    }
                    IFurnitureFactory factory = null;
                    if (furnitureType.Equals("modern"))
                    {
                        factory = new ModernFurnitureFactory();
                    }
                    else if (furnitureType.Equals("classical"))
                    {
                        factory = new ClassicalFurnitureFactory();
                    }

                    // 根据工厂生产椅子和沙发
                    IChair chair = factory.CreateChair();
                    ISofa sofa = factory.CreateSofa();

                    // 输出家具信息
                    chair.ShowInfo();
                    sofa.DisplayInfo();
                }
            }
            else
            {
                Console.WriteLine("订单数量输入有误.");
            }
        }
    }
}