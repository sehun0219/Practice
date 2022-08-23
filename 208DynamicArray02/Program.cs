
//
//arr 2차원 배열의 {1,2,3}, { 4,5,6}, { 7,8,9}
//의 값을 초기화 하고 다음 결과 값과 값이 각 행이 1행씩 밀리고

//마지막 행이 첫번째 행으로 돌아오는 프로그램을 만드시오.

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





