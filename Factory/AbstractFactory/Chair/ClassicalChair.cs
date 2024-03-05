namespace Factory.AbstractFactory.Chair
{
    /// <summary>
    /// 古典风椅子实现类
    /// </summary>
    public class ClassicalChair : IChair
    {
        public void ShowInfo()
        {
            Console.WriteLine("classical chair");
        }
    }
}
