
// static class는 정적 함수와 정적 변수만을 내부에 넣을 수 있어
// 그래서 생성자를 못만들어 *참고*
static class GTest
{
    //public GTest()
    //{

    //}


    // 제네릭 함수의 용법 

    //public static void ConsolePrint(int _Value)
    //{
    //    Console.WriteLine(_Value);
    //}
    //public static void ConsolePrint(string _Text)
    //{
    //    Console.WriteLine(_Text);
    //}

    // 자료형이 필요할때마다 만들어주어야 하니
    // 자료형을 변수처럼 쓰고싶네

    // 함수의 식별자에 <다양한 자료형을 대표할 이름> , <T> 이런식으로 보통
    

    public static T ConsolePrint<T>(T _value)
    {
        Console.WriteLine(_value);
        return _value;
    }
    public static T ConsolePrint<T,U>(T _value1, U _value2)
    {
        Console.WriteLine(_value1);
        Console.WriteLine(_value2);
        return _value1;

    }
}

// 제네릭 클래스
// 게임아이템과 캐쉬아이템으로 아이템을 구분했음
// 그런데 인벤에 넣는 기능은 게임아이템이나 캐쉬아이템 모두 필요한 함수임
// 각자의 클래스에 만들어주기 보다는 인벤이라는 제네릭 클래스에서 하나의 함수만 만들어서 
// 해결하면 코드를 줄일 수 있음.
class Inven<T>
{
    T[] ArrInvenItem;
    public void ItemIn(T _Itme)
    {
        Console.WriteLine("인벤에 아이템을 넣습니다.");
    }
}
class CashItem
{

}
class GameItem
{

}

class Program
{
    static void Main(string[] args)
    {
        GTest.ConsolePrint<int>(1000);
        GTest.ConsolePrint("하하하호호호");
        GTest.ConsolePrint(3.141592f);
        GTest.ConsolePrint("하하하호호호","123456");


        // 이녀석은 참조하는애 < > 이 부분을 생략할 수 없음
        GameItem NewGameItem = new GameItem();
        Inven<GameItem> NewGameItemInven = new Inven<GameItem>();
        NewGameItemInven.ItemIn(NewGameItem);

        CashItem NewCashItem = new CashItem();
        Inven<CashItem> NewCashItemInven = new Inven<CashItem>();
        NewCashItemInven.ItemIn(NewCashItem);
    }
}