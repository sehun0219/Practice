// 객체지향 프로그래밍에서 가장 처음으로 해야 할 일은 

// 프로젝트를 만들고 클래스를 선언하고 클래스안의 맴버변수와 맴버함수를
// 선언한다.

// 이때 맴버 함수를 제대로 쓰는 방법을알아야함

class Player
{
    // 접근제한 지정자를 입력하지 않으면 디폴트로 private임
    // private가 일반적인것임
    // 이 안에있는 속성은 외부에서 접근하지 못하는게 좋음 일반적으로
    public int att = 10;
    public int hp = 100;
    public int lv = 1;
    //플레이어의 레벨이 얼만지 알고싶다면, 
    //인자값이 아니고 리턴값을 사용할 수 있다.
    //리턴값이란 객체가 자신의 상태를 외부에 알려주는 용도로 사용된다.
    //외부에 알려줘야 하기 때문에 알려주는 순간 함수가 끝나게 된다.
    public int GetLv()
    {
        lv = 10;
        return lv;
        // 이렇게 리턴 아래에다 써주면 무시된다.
        lv = 0;
    }

    // 여기에 값을 넣고 이 값을 실행하는 것
    // 이런 모양으로 함수를 만드는 것에 장점
    // 1.브레이크 걸고 값 확인 가능 (hp가 바뀌는 순간 마다 이 코드만 확인 하면됨)
    // 2.맴버 변수가 변화하는 순간 함수로 지정해줘서 사용해야 편함
    // (랩업해서 공격력이 증가하는순간이면 뭔가 증가하는 코드를 처줘야 하는데 모든 코드를
    // 매번 치는것이아니라 함수로 만들어서 쓰면 편하다.)

    public void SetHp(int _HP)
    {
        hp = _HP;
    }
    // 함수는 보통 선언과 내용으로 나뉜다. 
    // 함수란 보통 클래스 외부와의 소통을 위해서 만든다. 
    // 메인함수 안에서 객체가 실행될 때 숫자를 넣으면 함수에 적용되게 끔 하려면 
    // 인자를 통해서 함수를 만들어주면 된다.

    // (int _Dmg)를 넣는다는 것은 외부에서 한개의 int 값을 넣어서 플레이어에게
    // 전달해 주겠다는 의미임  
    public void Damage1(int _dmg)
    {
        hp = hp - _dmg; // hp를 _dmg만큼 깎아주는 함수
    }
    // 인자값의 갯수는 신경안써도 될정도로 100개 이상 넣을 수 있다.
    public void Damage2(int _dmg, int _subDamage)
    {
        hp = hp - _dmg;
        hp = hp - _subDamage; 
    }
    // _dmg가 30을 받으면 hp가 기본 100 이니까 70이 된다.
    public int DamageToHpReturn(int _dmg) 
    {
        hp = hp - _dmg;
        return hp;
    }
    public void LvUp()
    {
        att = 100;
        hp = 1000;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        // NewPlayer.att = 10;
        // NewPlayer.hp = 0; 
        // 이렇게 적어놓으면 플레이어가 죽어버리기 때문에
        // 이런건 프라이빗으로 막아놓는다.
        //NewPlayer.SetHp(10);
        //NewPlayer.LvUp();
        //NewPlayer.Damage1(10);
        //NewPlayer.Damage1(20);
        //NewPlayer.Damage2(10,20);
        // 이런식으로 외부의 값을 받아서 나의 객체가 내부의 상태를 변화시키기
        // 위해서 함수를 선언하는 경우가 많다. 

        // 리턴의 사용
        Console.WriteLine(NewPlayer.GetLv());
        Console.WriteLine(NewPlayer.DamageToHpReturn(30));
    }
}