namespace Singleton
{
    /// <summary>
    /// 饿汉模式
    /// </summary>
    public class EagerSingleton
    {
        private static readonly EagerSingleton instance = new EagerSingleton();

        public EagerSingleton()
        {
            // 私有构造函数，防止外部实例化
        }

        public static EagerSingleton GetInstance()
        {
            return instance;
        }

        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }
}
