


class Program
{
    static void Main(string[] args)
    {
        //괄호안에 bool값이 들어감
        

        int count = 0;
        while (count < 5)
        {
            Console.WriteLine(count);
            count++;
        }

        do
        {
            count++;
            Console.WriteLine(count);
        }
        while (count < 5);
    }
}