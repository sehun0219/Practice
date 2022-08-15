class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 100; i++)
        {
            if (0 == i % 2)
            {
                // 컴파일러가 컨티뉴를 만나면 
                // 반복문의 증감문으로 바로 이동한다. i++
                continue;
            }
            Console.WriteLine(i);
        }
        for (int i = 0; i < 100; i++)
        {
            if (50 < i)
            {
                // 컴파일러가 브레이크를 만나면 
                // 가장 가까이 있는 반복문을 빠저나간다.
                break;
            }
        }
    }
}