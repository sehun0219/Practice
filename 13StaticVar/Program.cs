
//static // 메모리의 데이터영역에 저장됨

// 공유하고싶은 값.
// 객체를 아무리 만들어도 정적 맴버는 그 객체와의 관련성이 객체 내부에서 사용할수 있다 뿐이지 
// 객체의 갯수만큼 만들어지는것이 아님
// 즉 모든 객체가 공유하는 하나의 변수
// 예를들면 몬스터가 100마리 죽으면 뭔가 되어야함


// 스테틱 변수는 하나만 존재하며 클래스 내부에서 모든 객체가 공유하고싶은 변수를 만들
// 때 사용한다.

class Monster
{
    static int monsterDeathCount;
    public void Death()
    {
        monsterDeathCount++;
    }
}

class Player
{
    public static int PlayerCount = 0; // 이런걸 만들수 있음 (정적맴버변수)
    // 정적맴버변수는 일반적인 맴버변수와는 다르게 객체화를 하지 않고도 쓸수 있음
    // 클래스의 이름만으로 사용할 수 있다. (사용법)

    public int att = 10 ;
    public int hp = 100;

    public void Setting(int _att, int _hp)
    {
        att = _att;
        hp = _hp;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player();
        Player.PlayerCount = 1; // 객체 안만들어도 쓸수 있음 클래스 이름에 점찍고 변수이름 써서
        Player player2 = new Player();
        Player.PlayerCount = 2; // 이런 정적맴버변수는 메모리영역 데이터에 들어감
        Player player3 = new Player();
        Player.PlayerCount = 3;

        // 플레이어 123 처럼 세번 만들면 플레이어가 세개 생김 // 힙에 생긴거임
        player1.Setting(10,100);
        player2.Setting(20, 50);
        player3.Setting(100, 500);

        Monster monster1 = new Monster();
        Monster monster2 = new Monster();
        Monster monster3 = new Monster();

        monster1.Death();
        monster2.Death();
        monster3.Death();
        // monsterdeathcount 가 3이됨 


    }
}


