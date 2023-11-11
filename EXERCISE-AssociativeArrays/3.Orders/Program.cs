namespace _3.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] splitInput = new string[]{};

            Dictionary<string, Product> productList = new Dictionary<string, Product>();

            while ((input = Console.ReadLine()) != "buy")
            {
                splitInput = input.Split(' ');
                Product newProduct = new Product(splitInput[0], decimal.Parse(splitInput[1]), decimal.Parse(splitInput[2]));

                if (!productList.ContainsKey(newProduct.Name))
                { 
                    productList.Add(newProduct.Name, newProduct);
                }
                else
                {
                    productList[newProduct.Name].Update(newProduct.Quantity, newProduct.Price);
                }
            }

            foreach (KeyValuePair<string, Product> pair in productList)
            {
                Console.WriteLine(pair.Value);
            }
        }

        class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }

            public decimal TotalPrice => Price * Quantity;

            public Product(string name, decimal price, decimal quantity)
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

            public void Update(decimal newQuantity, decimal newPrice)
            {
                Quantity += newQuantity;
                Price = newPrice; 
            }

            public override string ToString()
            {
                return $"{Name} -> {TotalPrice:F2}";
            }
        }
    }
}