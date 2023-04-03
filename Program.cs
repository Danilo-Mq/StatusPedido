using Seção9_Exercicio3.Entities;
using Seção9_Exercicio3.Entities.Enums;
using System.Globalization;


namespace Seção9_Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            DateTime OrderData = DateTime.Now;
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>("Processing");
            
            Client client = new Client(name, email, birthDate);
            Order order = new Order(OrderData, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                String NameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product Product = new Product(NameProduct, price);

                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem item = new OrderItem(quantity, price, Product);

                order.AddItem(item);
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
           
        }
    }
}