namespace Singleton
{
    /// <summary>
    /// 懒汉模式 + 双重检查锁
    /// </summary>
    public class LazySingleton
    {
        private static volatile LazySingleton instance;
        private static readonly object locker = new object();

        public LazySingleton()
        {
            // 私有构造函数，防止外部实例化
        }

        public static LazySingleton GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new LazySingleton();
                    }
                }
            }
            return instance;
        }
        public void GetInfo()
        {
            Console.WriteLine(string.Format("I am {0}.", this.GetType().Name));
        }
    }
}
