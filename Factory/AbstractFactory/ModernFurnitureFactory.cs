using Factory.AbstractFactory.Chair;
using Factory.AbstractFactory.Sofa;

namespace Factory.AbstractFactory
{
    /// <summary>
    /// 现代风格家居工厂实现类
    /// </summary>
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
