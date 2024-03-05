namespace Factory.FactoryMethod.Square
{
    /// <summary>
    /// 具体方形积木实现
    /// </summary>
    public class SquareBlock : IBlock
    {
        public void Produce()
        {
            Console.WriteLine("Square Block");
        }
    }
}
