

class Program
{

    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int input2 = Convert.ToInt32(input);

        int[] arr = new int[input2];
        for (int i = 0; i < arr.Length; i++)
        {
            string val = Console.ReadLine();
            int val1 = Convert.ToInt32(val);
            arr[i] = val1;
        }
        
    }
}



//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i] + " ");
//}