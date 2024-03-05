namespace Factory.FactoryMethod
{
    /// <summary>
    /// 抽象积木工厂接口
    /// </summary>
    public interface IBlockFactory
    {
        IBlock CreateBlock();
    }
}
