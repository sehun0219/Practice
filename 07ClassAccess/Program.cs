







class Player
{   
    // 객체지향의 캡술화 은닉화를 대표하는 문법
    // 접근제한 지정자
    // 기본은 비공개임
    public int att; // 외부에도 공개
    protected int hp; // 자식에게만 공개
    private int def; // 비공개
    public void Fight()
    {
        Console.WriteLine("fight");  
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 객체지향의 캡술화 은닉화를 대표하는 문법
        // 접근제한 지정자
        // 기본은 비공개임
        // 변수든 함수든 접근제한 지정자 다 필요함
        Player newPlayer = new Player();
        newPlayer.att = 1;
        newPlayer.Fight();

    }
}