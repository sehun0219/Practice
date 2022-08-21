

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
        };
        int[] temp = new int[1];
        

        for (int i = 0; i < arr.Length; i++)
        {
            temp[0] = arr[i][2];
            arr[i][2] = arr[i][1];
            arr[i][1] = arr[i][0];
            arr[i][0] = temp[0];
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}