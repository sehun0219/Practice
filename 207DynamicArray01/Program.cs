

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[][] 
        {
            new int[] {1,2,3,4},
            new int[] {5,6,7},
            new int[] {8,9}
        };
        
        

        arrPrint(arr);
        addTwoArr(arr, 1);
        Console.WriteLine("---------");
        arrPrint(arr);
    }
    static void arrPrint(int [][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void addOneArr(int[] Array, int PlusValue)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = Array[i]+ PlusValue;
        }
    }
    static void addTwoArr(int[][] Array, int PlusValue)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            addOneArr(Array[i], PlusValue);
        }
    }
}