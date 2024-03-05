namespace Factory.FactoryMethod.Square
{
    public class SquareBlockFactory : IBlockFactory
    {
        public IBlock CreateBlock()
        {
            return new SquareBlock();
        }
    }
}
