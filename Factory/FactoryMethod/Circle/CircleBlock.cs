namespace Factory.FactoryMethod.Circle
{
    /// <summary>
    /// 具体圆形积木实现
    /// </summary>
    public class CircleBlock : IBlock
    {
        public void Produce()
        {
            Console.WriteLine("Circle Block");
        }
    }
}
