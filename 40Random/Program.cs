


// 랜덤값을 리턴하는 단일 함수는 없다.
// 랜덤 알고리즘을 쓸때는 매번 변하는수를 seed로 정하고 그수를 이용해서 랜덤값을 만들어준다.
// 보통 시간처럼 변하는 값을 seed로 쓴다.






class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        while (true)
        {
            int ran = random.Next(0,10);
            Console.WriteLine(ran);
        }
    }
}


