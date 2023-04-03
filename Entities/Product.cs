namespace Seção9_Exercicio3.Entities
{
    class Product
    {
        public String Name { get; set; }
        public Double Price { get; set; }

        public Product()
        {

        }

        public Product(string NameProduct, double price)
        {
            Name = NameProduct;
            Price = price;
        }
    }
}
