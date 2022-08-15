//배열을 사용해 홀수와 짝수를 구분해 출력시키기
//◎입력 예제
//4 6 9 50 85 91 15
//◎출력 예제
//9 85 91
//4 6 50

// 배열을하나만든다. 값을 6개 집어넣는다.
// 값이 들어오고 그 값이 짝수이면 배열A의 인덱스로 들어간다.
// 값이 홀수면 배열 B로 들어간다.
// 입력이 끝나면 각 배열을 출력한다.


class Program
{
    public int countEven;
    public int countOdd;

       

    static void Main(string[] args)
    {
        Program program = new Program();
        Console.WriteLine("몇 개짜리 배열을 만들까요?");
        
        string num = Console.ReadLine();
        int total = Convert.ToInt32(num);
        int[] arr = new int[total];
        int[] arrEven = new int[total]; // 짝수의 갯수를 카운트해서 그것만큼 만들어줄 수 있을듯
        int[] arrOdd = new int[total];

        Console.Write("입력받은 값들 : ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine(" ");

        Console.Write("입력받은 값 중 짝수는 : ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arrEven[i] != 0)
            {
                Console.Write(arrEven[i] + " ");
                program.countEven++;
            }
        }
        Console.WriteLine(" ");
        Console.Write("입력받은 값 중 홀수는 : ");
        for (int i = 0; i < arr.Length; i++)
        {
            if (arrOdd[i] != 0)
            {
                Console.Write(arrOdd[i] + " ");
                program.countOdd++;
            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("입력받은 값 중 홀수는 : "+ program.countOdd+"개 입니다.");

        Console.ReadLine();
    }
}