namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShoppingCartManager cart = ShoppingCartManager.GetInstance();
            while (true)
            {
                Console.WriteLine("请输入名称 (或输入exit结束):");
                string itemName = Console.ReadLine();

                if (itemName.ToLower() == "exit")
                {
                    break;
                }

                Console.WriteLine("请输入数量:");
                if (int.TryParse(Console.ReadLine(), out int quantity))
                {
                    // 获取购物车实例并添加商品
                    cart.AddToCart(itemName, quantity);
                }
                else
                {
                    Console.WriteLine("输入有误.");
                }
            }

            // 输出购物车内容
            Console.WriteLine("查看购物车:");
            cart.ViewCart();
        }
    }
}
