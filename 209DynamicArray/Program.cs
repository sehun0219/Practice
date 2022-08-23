

// 10x10 이하의 정수형 이차원 배열을 입력 받아 == 이부분 말이 이해가 안됨..
// 그 배열의 각 행의 요소의 합을 출력하는 프로그램을 만들어보세요.

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[][]
        {
            new int [] { 90, 100, 40, 60 },
            new int [] { 80, 90 },
            new int [] { 100, 80, 20 }
        };

        // 여기서부터
        for (int i = 0; i < 3; i++)
        {
            arr[i][2] = arr[i][0] + arr[i][1];
            arr[i][3] = arr[i][2] / 2;
        }
        Console.WriteLine("국어 영어 합계 평균");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(arr[i][j]+ "   ");
            }
            Console.WriteLine();
        }
        
    }
}




