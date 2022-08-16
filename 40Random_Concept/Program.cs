class Program
{
    
    static void Main(string[] args)
    {
        Random random = new Random();
        while (true)
        {
            int ran = random.Next(0, 7); // max가 10이면 9까지나옴
            Console.WriteLine(ran);
            Console.ReadKey();
        }
    }
}

