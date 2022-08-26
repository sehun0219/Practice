class Is
{
    static void Main(string[] args)
    {
        object x = 1234;
        if(x is int) // 비교 후 참인지 거짓인지 리턴
        {
            Console.WriteLine("x can be int");
        }
        string s = x as string; // x가 인트라서 스트링으로 변환이 안되니까 null 값이 됨
        Console.WriteLine(s == null? "null":s);

    }
}