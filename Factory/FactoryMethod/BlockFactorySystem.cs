namespace Factory.FactoryMethod
{
    /// <summary>
    /// 积木工厂系统
    /// </summary>
    public class BlockFactorySystem
    {
        private List<IBlock> blocks = new List<IBlock>();

        public void ProduceBlocks(IBlockFactory factory, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                IBlock block = factory.CreateBlock();
                blocks.Add(block);
                block.Produce();
            }
        }

        public List<IBlock> GetBlocks()
        {
            return blocks;
        }
    }
}
