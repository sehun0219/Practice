
class Array
{
    public int[]? arr;

    public void Starting()
    {
        Console.WriteLine("인덱스가 몇개인 배열을 만들까요?");
    }
    public int GetIndexNum() 
    {
        int indexNum = Convert.ToInt32(Console.ReadLine());
        return indexNum;
    }
    public void AddIndexValue()
    {
        Console.WriteLine("=== 값을 입력하세요 ===");
        for (int i = 0; i < arr?.Length; i++)
        {            
            string inputValue = Console.ReadLine();
            int inputvalue = Convert.ToInt32(inputValue);
            arr[i] = inputvalue;
        }
    }
    public void PrintEvenNum(int[] arr)
    {
        int even = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                even = arr[i];
                Console.Write(even + " ");
            }
        }
        Console.ReadLine();
    }

    public void PrintOddNum(int[] arr)
    {
        int Odd = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                Odd = arr[i];
                Console.Write(Odd + " ");
            }
        }
        Console.ReadLine();
    }
}


class Program
{
    static void Main(string[] args)
    {
        Array NewArr = new Array();
        NewArr.Starting();
        NewArr.arr = new int[NewArr.GetIndexNum()];
        Console.WriteLine("배열을 만들었습니다.");
        Console.WriteLine("배열에 넣을 값들을 입력해주세요.");
        NewArr.AddIndexValue();
        Console.Write("짝수만 출력합니다 : ");
        NewArr.PrintEvenNum(NewArr.arr);
        Console.Write("홀수만 출력합니다 : " );
        NewArr.PrintOddNum(NewArr.arr);
    }
}