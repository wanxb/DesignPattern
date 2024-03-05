using Factory.AbstractFactory.Chair;
using Factory.AbstractFactory.Sofa;

namespace Factory.AbstractFactory
{
    /// <summary>
    /// 古典风格家居工厂实现类
    /// </summary>
    public class ClassicalFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ClassicalChair();
        }

        public ISofa CreateSofa()
        {
            return new ClassicalSofa();
        }
    }
}
