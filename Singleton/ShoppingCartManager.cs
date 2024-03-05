namespace Singleton
{
    /// <summary>
    /// 购物车管理器
    /// </summary>
    public class ShoppingCartManager
    {
        private static volatile ShoppingCartManager instance;
        private static readonly object locker = new object();

        private Dictionary<string, int> cart;
        public ShoppingCartManager()
        {
            cart = new Dictionary<string, int>();
        }

        public static ShoppingCartManager GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new ShoppingCartManager();
                    }
                }
            }
            return instance;
        }

        public void AddToCart(string itemName, int quantity)
        {
            cart.Add(itemName, cart.GetValueOrDefault(itemName) + quantity);
        }

        public void ViewCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
    }
}
