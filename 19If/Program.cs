class Program
{
    static void Main(string[] args)
    {
        int Test = 100;
        // 조건문 - 괄호안에 내용이 참이면 코드를 실행한다.
        if (Test != 100)
        {
            Console.WriteLine("Test is not equle to 100");
        }
        else if (Test == 100) // 위의 조건이 거짓일때 아래 조건을 확인하고 참이면 코드를 실행
        {
            Console.WriteLine("Test is equle to 100");
        }


        int Elsetest = 5;
        if (Elsetest==100)
        {
            Console.WriteLine("Elsetest is 100");
        }
        else if (Elsetest==200)
        {
            Console.WriteLine("Elsetest is 200");
        }
        else
        {
            Console.WriteLine("the things existing are false ");
        }
    }
}