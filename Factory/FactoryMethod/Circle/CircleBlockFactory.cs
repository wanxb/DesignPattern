namespace Factory.FactoryMethod.Circle
{
    public class CircleBlockFactory : IBlockFactory
    {
        public IBlock CreateBlock()
        {
            return new CircleBlock();
        }
    }
}
