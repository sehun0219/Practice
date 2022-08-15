
class FightUnit
{
    protected int AT;
    public FightUnit()
    {
        int a = 0;
    }
}


// 두구역 중에 누가먼저만들어질까? 
// fightUnit 부터 만들어짐
// 
class Player : FightUnit
{
    // = 생성자 constructer =
    // 메모리가 만들어질때 한번 실행되어주는 함수 
    // 눈에 보이지 않지만 만들지 않아도 이 함수는 만들어 진다.
    // 리턴값과 인자가 없는 함수 모양.. 왜냐?
    // 새로 생성되는 자신의 클레스의 메모리를 참조해서 리턴해줘야하니까
    // private 해버리면 객체못만듬
    public Player()   
    {
        AT = 100;
        int a = 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(); // 리턴값이 Player 인 새로운 메모리를 만들겠다는 의미임
    }
}

class DynamicArray2 // extent array length by twice
{
    private int[] arr;
    private const int GROWTH_FACTOR = 2;

    public int Count { get; private set; }
    public int Capacity { get { return arr.Length; } }
    public DynamicArray2(int Capacity = 16)  // 위에 필드들을 재 정의해주면서 클래스를 완성할 수있다.
    {
        arr = new int[Capacity];
        Count = 0;
    }

}