

// c#은 고지식한 객체지향 언어 = 클래스만 아는 바보
// 프로그램의 시작조차도 클래스안에 묶어놔야 한다.

class Player
{
    // 맴버변수 = 클래스의 맴버여서 맴버변수라고 부름
    int att = 1;
    int hp = 10;

    void Fight()
    {
        int damage = 0;
        // 함수안에 있으므로 지역변수임
        // 이 함수 밖에서는 쓸수 없음 안에서만 사용가능
        // 선언되는순간 지역변수는 메모리화 되고 함수가 끝나면 메모리
        // 할당이 사라짐
        // 잠깐 계산할때 쓰고 버리고 싶은 변수는 이렇게 만들어 쓰고 버림

        Console.WriteLine("player fight");
    }
}
// 게임에서 사용하기 위해서 설계해둠


class Program
{
    //시작용 함수가 있는것이고
    static void Main(string[] args)
    {
        int att = 0; // 함수안에 있는 변수를 지역변수라고 한다.
        att = 50;

        // 지역변수 규칙
        // 내부에서만 사용가능하다.
      


        //객체화
        //설계해둔 플레이어 클래스 대로 NewPlayer를 만들어서 쓰려면
        Player newPlayer = new Player();


        Console.WriteLine("지역변수를 공부해 봅시다.");
    }
}