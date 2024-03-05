namespace Factory.AbstractFactory.Chair
{
    /// <summary>
    /// 现代风椅子实现类
    /// </summary>
    public class ModernChair : IChair
    {
        public void ShowInfo()
        {
            Console.WriteLine("modern chair");
        }
    }
}
