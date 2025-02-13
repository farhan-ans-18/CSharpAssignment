using System.Collections;

namespace ProductCollection1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Product> list = new List<Product>();
           list.Add(new Product(200, "DEll", "15 inch Monitor", 3400.44));
           list.Add(new Product(120, "DEll", "Laptop", 45000.00));
           list.Add(new Product(150, "Microsoft", "Windows 7", 7000.50));
           list.Add(new Product(100, "LogiTech", "Optical Mouse", 540.00));
            list.Sort();
            Console.WriteLine("Enter the option to sort: ");
            Console.WriteLine("1. For sort by Brand Name");
            Console.WriteLine("2. For sort by price");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                list.Sort(new sortByBrandName());
            }
            else if (option == 2)
            {
                list.Sort(new sortByPrice());
            }
            else
            {
                Console.WriteLine("Invalid input");
            }




            for (int i = 0; i < list.Count; i++)
            {
                Product product = list[i];
                Console.WriteLine(product.ToString());
            }


        }

        class Product : IComparable<Product> 
        {
            public int ProductId { get; set; }
            public string BrandName { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }

            public Product(int ProductId, string BrandName, string Description, double Price) 
            { 
                this.ProductId = ProductId;
                this.BrandName = BrandName;
                this.Description = Description;
                this.Price = Price;
            }
            public int CompareTo(Product other)
            {
                if (other == null) return 1;
                return this.ProductId.CompareTo(other.ProductId);
            }

            public override string ToString()
            {
                return $"Product ID : {ProductId}\nBrand Name: {BrandName}\nDescription: {Description}\nPrice: {Price}\n..........";

            }
        }

        class sortByBrandName : IComparer<Product>
        {
            int IComparer<Product>.Compare(Product? x, Product? y)
            {
                if (x.BrandName.CompareTo(y.BrandName) == 1)
                {
                    return 1;
                }
                else if (x.BrandName.CompareTo(y.BrandName) == -1)
                {
                    return -1;
                }
                else
                {
                    if (x.Description.CompareTo(y.Description) == 1)
                    {
                        return 1;
                    }
                    else if (x.Description.CompareTo(y.Description) == -1)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        class sortByPrice : IComparer<Product>
        {
            int IComparer<Product>.Compare(Product? x, Product? y)
            {
                if (x.Price.CompareTo(y.Price) == 1)
                {
                    return 1;
                }
                else if (x.Price.CompareTo(y.Price) == -1)
                {
                    return -1;
                }
                else
                {
                    if(x.ProductId.CompareTo(y.ProductId) == 1)
                    {
                        return 1;
                    } else if(x.ProductId.CompareTo(y.ProductId) == -1)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }





    }
}
