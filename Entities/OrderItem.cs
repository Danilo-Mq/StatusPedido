using System.Globalization;


namespace Seção9_Exercicio3.Entities

{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, Product NameProduct)
        {
            Quantity = quantity;
            Price = price;
            Product = NameProduct;
        }


        public Double SubTotal()
        {
            return Quantity * Price;
        }


        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
