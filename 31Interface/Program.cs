
// 사용자 정의 자료형
// 맴버변수를 안에 넣을 수 없음
// 함수의 형태만 물려 줄수 있는 문법임
// 인터페이스 맴버 함수에는 정의를 사용할 수 없다.
// 무조건 퍼블릭이다.
// 인터페이스로 뭘 만들어 놓고 연결시켜놓으면 인터페이스에있는 함수를 무조건 써야함 // 장점 : 무조건 있어야하는 걸 안빼먹고 사용할 수 있음
// 다중상속이 가능함
// 내용이 없으니까 충돌이 없기때문에
// 두개의 클래스를 동시에 상속받으면 이름이나 이런게 겹칠수 있어서 복잡해짐.



interface QuestUnint
{

    void Talk(QuestUnint _OtherUnit)
    {

    }
    void Event(QuestUnint _OtherUnit)
    {

    }
}

class FightUnit
{
    int AT;
    int DMG;
    public void Damage()
    {

    }
}

class Player : FightUnit , QuestUnint
{
    public void talk(QuestUnint _OtherUnit)
    {

    }
    public void Event(QuestUnint _OtherUnit)
    {

    }
}
class Monster : FightUnit
{
    
}
class  NPC : FightUnit , QuestUnint
{
    public void talk(QuestUnint _OtherUnit)
    {

    }
    public void Event(QuestUnint _OtherUnit)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        NPC nPC = new NPC();
        // QuestUnint questUnint = new QuestUnint(); // 실체가 없기 때문에 구현하지 못한다.
        QuestUnint questUnint = nPC;
        questUnint.Talk(player);
        player.talk(nPC);
    }
}