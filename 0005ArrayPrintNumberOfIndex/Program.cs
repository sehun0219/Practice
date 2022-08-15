

class Program
{
    static void Main(string[] args)
    {
        int count = 0;
        int[] arr = new int[10];
        Console.WriteLine("인덱스가 5인 배열이 있습니다. 값을 입력해주세요");
        for (int i = 0; i < arr.Length; i++)
        {
            string? input = Console.ReadLine();
            int value = Convert.ToInt32(input);
            arr[i] = value;
        }
        Console.WriteLine("배열값에 있는지 찾을 숫자를 입력해 주세요");
        string? input2 = Console.ReadLine();
        int addValue = Convert.ToInt32(input2);
        for (int i = 0; i < arr.Length; i++)
        {
            if (addValue == arr[i])
            {
                count++;
            }
        }
        if (count!=0)
        {
            Console.WriteLine("입력값 : " + addValue + "이 " + count + "개 있습니다.");
        }
        else
        {
            Console.WriteLine("입력값: " + addValue + "가 없습니다.");
        }
    }
}

//사용자로부터 5개의 배열로 입력 받은 
//후 숫자 하나를 추가로 입력 받아 
//그 수가 배열에 몇개 존재하는 지를 출력


//1. 5칸이 있는 배열을 만든다.
//2. 사용자로부터 5개의 숫자를 입력받는다.
//3. 입력받은 숫자가 배열을 채운다.

//4. 사용자로부터 숫자하나를 더 입력받는다.

//5. 사용자가 입력한 값이 배열에 있으면 
//몇개 있는지 카운트 해서 그 값을 출력한다.

//6. 값이 없으면 없다고 출력한다.