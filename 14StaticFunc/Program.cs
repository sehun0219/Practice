public class Player
{
    int hp = 100;
    int att = 10;
    public void Damage(int _dmg)
    {
        hp = hp -_dmg;
    }
    //스테틱 함수
    //스테틱 맴버변수는 클래스이름 + . 하면 변수를쓸수 있었지
    //Console. 이런것처럼

    // 자기자신의 레퍼런스는 퍼블릭처럼 씀
    static public void PVP(Player _left, Player _right)
    {
        _left.hp = _left.hp - _right.att;
        _right.hp = _right.hp - _left.att;
    }
    //static public void PVE(Player _left, Monster _right)
    //{
    //    _left.hp = _left.hp - _right.att;
    //    _right.hp = _right.hp - _left.att;
    //}
    //public class Monster
    //{
    //    int hp = 100;
    //    int att = 10;
    //} // 이렇게는 안됨 몬스터를 레퍼런스로 받고있으니까

}
class Program
{
    static void Main(string[] args) // 정적맴버함수기때문에 프로그램 전체에 관여함
    {
        Console.WriteLine("I am studing 'static'"); //
        // Console 이 클래스를 객체화 하지 않고 . 눌러서 바로 함수를 실행하고 있다
        // WriteLine도 static member function이라는 말임



        //Player player1 = new Player();
        //Player player2 = new Player();

        ////객체를 굳이 만들지 않고도
        ////함수를 사용할 수 있음 (정적맴버함수)
        //Player.PVP(player1, player2);
    }
}