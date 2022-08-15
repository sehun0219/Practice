class FightUnit
{
    protected string Name = "None";
    protected int AT = 10;
    protected int HP = 100;

    protected virtual int GetAT() // virtual 부모쪽이 가짜다 // 부모의 접근제한 지정자와 자식의 접근제한 지정자가 같아야한다. 모든 상황이 같아야한다. 
    {
        //Console.WriteLine("FightUnint의 GetAT");
        return AT; 
    }

    // 업캐스팅(형변환)
    public void Damage(FightUnit _OtherFightUnit)
    {
        // 플레이어의 공격력과 몬스터의 공격력을 나눠 줘야함
        int AT = _OtherFightUnit.GetAT();
        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "의 데미지를 입었습니다.");
        HP -= AT;
    }
}
class Player : FightUnit
{
    int ItemAt = 5;
    protected override int GetAT() // override // 맴버 함수와 프로퍼티 두개만 오버라이딩이 가능함.
    {
        //Console.WriteLine("Player의 GetAT");
        return AT + ItemAt;
    }
    public Player(string _Name)
    {
        Name = _Name;
    }
}
class Monster : FightUnit
{
    int MonsterLv = 0;
    protected override int GetAT()
    {
        return MonsterLv + AT;
    }
    public Monster(string _Name, int monsterLv)
    {
        Name = _Name;
        MonsterLv = monsterLv;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer1 = new Player("player1");
        Monster NewMonster1 = new Monster("Monster1",1);
        
        NewPlayer1.Damage(NewMonster1);
        NewMonster1.Damage(NewPlayer1);
    }
}