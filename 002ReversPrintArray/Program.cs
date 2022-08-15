
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[6];

        for (int i = 0; i < arr.Length; i++)
        {
            string numbers = Console.ReadLine();
            int value = Convert.ToInt32(numbers);
            arr[i] = value;
        }
        for (int i = arr.Length- 1; i >= 0; i--)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadLine();
    }
}

