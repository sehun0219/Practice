


// 반복문은
// 함수안에서는 언제든지 사용할수 있지만 
// 함수 밖에서는 못쓴다.
class Program
{
    static void Main(string[] args)
    {

        // 모든 반복문은 while문으로 표현가능하지만 
        // for 가 편할때가 있기때문에 for 를 쓴다. 
        // 초기화 조건 증감문을 모두 제공하기때문에 불편하지 않음

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        int j = 0;
        for (; j < 10; j++)
        {
            Console.WriteLine(j);
        }
         
        for (; true; )
        {
            Console.WriteLine(100);
        }
        // while (true)
        // {
        //    Console.WriteLine(100);
        // } 이거랑 같음
    }
}