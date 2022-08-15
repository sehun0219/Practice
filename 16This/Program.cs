
// 객체지향의 핵심 개념임
// 대부분의 언어가 this를 써줌 그런데 파이썬 C#은 안써줘도 됨  



class Player
{
    int HP=100;
    static int att = 10;
    public static void Damage(Player _this, int _dmg) 
        // 스테틱은 객체가 없어도되는애임
    {
        _this.HP -= _dmg;
    }
    //public void Damage(int _dmg)
    //{
    //    // 플레이어2가 데미지 20을 받았다는 코드가 실행되었고
    //    // 그래서 HP를 깎는데 HP를 깎으려고 보니 
    //    // Player1,Player2,Player3이 각각 Hp를 갖고있네
    //    // 어떻게 Player2의 Hp를 찾아 깎을래?
    //    HP -= _dmg;
    //}

    public void Heal(Player _this, int _heal) //그냥 int heal 만 써도 되는데
    {
        _this.HP += HP; // 대상을 지칭해야함..  나한테 쓸건데.. 불편함.. 
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player();
        Player player2 = new Player();
        Player player3 = new Player();


        //Player.Damage(player2, 20); <- 스테틱함수만들어서 한경우
        //player2.Damage(20);   <- 함수만들어서 한경우

        // 자기자신한테 함수를 적용할때 맴버함수에서 멤버변수를 쓴다면 그것은
        // 눈에 보이지는 않지만 앞에 this.이 생략된 것이다. 
        // this 는 자기자신을 지칭하는것임.

        //스테틱 맴버함수에서 일반 맴버변수를 쓸수없는것은 this개념이 없기때문임
        // 스테틱 맴버함수는 객체를 만들지 않기때문에 특정할 것이 없으므로
        // 못써줌

        player1.Heal(player2, 10);
    }
}