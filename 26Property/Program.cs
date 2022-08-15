
class Player
{
    int AT = 10;
    public int HP = 110;
    
    public int ProAT // int 프로퍼티기 때문에 
    {
        get { return AT; }// 프로퍼티의 Get함수는 무조건 int를 리턴한다. // 이안에만보면 함수랑 같음 // 함수를 쓰는대신 축약해서 이렇게 씀
        set { AT = value; }// 위의 자료형이 int기 때문에 무조건 int 하나가 들어온다고 여김
                           // 그런 외부값들을 value라고 기호로 정해놓고 쓴다.
    }
   
    public int GetAT() // AT를 외부에 알려주는 함수
    {
        return AT;
    }
    public void SetAT(int _value) // AT를 수정하는 함수
    {
        if (99 < _value)
        {
            Console.WriteLine("Over AT!!!");
            while (true)
            {
                Console.ReadKey();
            }
            
        }
        AT = _value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        player.ProAT = 10; // 함수냐 맴버변수냐 프러퍼티냐???? 프러퍼티
        player.SetAT(9999); // 함수냐 맴버변수냐 프러퍼티냐???? 함수
        player.HP = 80; // 함수냐 맴버변수냐 프러퍼티냐???? 맴버변수
    }
}