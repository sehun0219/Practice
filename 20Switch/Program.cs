

class Program
{
    static void Main(string[] args)
    {
        int a = 100;
        

        switch (a) // 이녀석은 == 연산밖에 못함
        {
            case 0: // 변수는 조건으로 들어갈수 없음 상수만 비교할 수 있음
                Console.WriteLine("switch is 0");
                break;
            case 1:
                Console.WriteLine("switch is 1");
                break;
            case 2:
                Console.WriteLine("switch is 2");
                break;
            case 3:
                Console.WriteLine("switch is 3");
                break;

                default: //else 랑 같음
                Console.WriteLine("nothing there matched");
                break;
            
        }
    }
}