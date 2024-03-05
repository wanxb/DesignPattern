using Factory.AbstractFactory.Chair;
using Factory.AbstractFactory.Sofa;

namespace Factory.AbstractFactory
{
    /// <summary>
    /// 抽象家居工厂接口
    /// </summary>
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
