

class Program
{

    static void Main(string[] args)
    {
        //Console.WriteLine("몇개의 정수를 입력하겠습니까?");
        //string input = Console.ReadLine();
        //int input2 = Convert.ToInt32(input);
        //int[] arr = new int[input2];

        // 숫자를 입력하면 입력한 숫자가 차례대로 0번 인덱스부터 채워져서 마지막에 배열이 만들어지는..

        int input = int.Parse(Console.ReadLine());
        List<int> list = new List<int>(input);
        Console.WriteLine($"{input}리스트가 생성되 었습니다. 값을 입력해주세요");

        for (int i = 0; i < input; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("입력된 숫자");
        Console.WriteLine("=============");
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(list[i] +" ");
        }
        

        Console.WriteLine();
        Console.WriteLine("홀수번째 숫자");
        for (int i = 0; i < list.Count; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            Console.Write(list[i] + " ");
        }
        
        Console.WriteLine();
        Console.WriteLine("짝수번째 숫자");
        for (int i = 0; i < list.Count; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            Console.Write(list[i] + " ");
        }

        Console.ReadLine();

    }
}



