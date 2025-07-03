namespace week1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of small caarpets : ");
            int numSmall = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of large caarpets : ");
            int numLarge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("price per small room : $25 ");
            Console.WriteLine("price per large room : $35 ");

            int cost = numSmall * 25 + numLarge * 35;
            Console.WriteLine($"Cost : ${cost} ");

            double tax = cost * 0.06;
            Console.WriteLine($"Tax : ${tax} ");

            Console.WriteLine($"Total estimate : ${cost + tax} ");
            Console.WriteLine("This estimate is valid for 30 days ");




        }
    }
}
