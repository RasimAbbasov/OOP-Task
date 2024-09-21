namespace OOP_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsul sayini daxil edin:");
            int productcount =Convert.ToInt32(Console.ReadLine());
            Product[] products= new Product[productcount];
            int total = 0;
            int count = 0;
            for (int i = 0; i < productcount; i++) 
            {
                Console.WriteLine("Mehsulun adini daxil edin:");
                string productname = Console.ReadLine();
                Console.WriteLine("Mehsulun qiymetini daxil edin:");
                int productprice = Convert.ToInt32(Console.ReadLine());
                Product product = new Product(productname,productprice);
                products[i] = product;
                total+= productprice;
                count++;
            }
            int averageprice=total/count;
            int max = products[0].Price;
            int min = products[0].Price;
            foreach (var product in products)
            {
                if (product.Price > max)
                {
                    max = product.Price;
                }
                if(product.Price < min)
                    min = product.Price;
            }
            Console.WriteLine($"Ortalama mehsullarin qiymet:{ averageprice} en yuksek qiymetli mehsulun qiymeti:{max} en ucuz mehsulun qiymeti:{min}");

        }
    }
}
