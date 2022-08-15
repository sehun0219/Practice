// 클래스 상속이란
// 코드 재활용성을 향상시키기 위해서 (함수도 이역할을 함)
// 같은 코드를 두번치지 않기 위해서 쓴다.
// C#에서 상속이란 오직 한개만 상속가능하다.

// 접근제한자        public      Protected       private
// 범위            외부까지       자식까지        나만

// 비슷한 내용이 반복되는데? 이 느낌이 들면 써본다.

// 클래스 상속 사용법
// 1. 공통되는 맴버 변수와 맴버함수를 복사해서 새로운 클래스로 만든다.
// 2. 

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Monster monster = new Monster();
        // monster가 player는 참조하는게 다름 
        // 하지만 아래처럼 쓸수 있는데 그이유는 FightUnit이라는 메모리를 
        // 같이 쓰고있기 때문에 참조할 수 있음 (업케스팅이라고 함)
        // 자식이 부모형이 되고 자식의 능력은 버린다.
        monster.Damage(player);
        player.Damage(monster);

    }
}
class Player : FightUnit
{
    int Lv = 1;
    void Heal()
    {

    }
}
class Monster : FightUnit
{

}

class FightUnit
{
    protected int AT = 10;
    protected int HP = 100;
    public void Damage(FightUnit _OtherUnit)
    {
        this.HP -= _OtherUnit.AT;
    }
}