

class Player
{
    //직업에 관련된 맴버 변수도 있어야 할것.
    //이렇게 클래스 내부에 이넘을 만들어서 이 클래스만 쓰는 변수처럼 사용가능
    enum PLAYERJOB
    {
        NOVICE,
        KNIGHT,
        FIGHTER,
        FIREMAGE,
        BERSERKER,
    }
    void ClassChange()//전직하는 함수
    {

    }
}




class Inven // 큰 개념을 하나 만들고
{
    private int SelectIndex = 0; 

    public void InnerClassTest()
    {
        InvenSlot slot = new InvenSlot();
        slot.Select(this);
    }
    
    
    // 인벤슬롯 클래스를 인벤 밖에서 쓸일이 없으니까 안에다 만들어줌
    // private처럼 씀

    public class InvenSlot // 하위 개념의 클래스들인느낌이면 내부에서 만들어서 관리하는것이 좋다.
    {
        int Index;
        public void Select(Inven _inven) // Inven class를 참조하는 변수 _inven을 인자로 갖는 함수로 만든다음 객체를 불러와서 연결하면
                                  // 사용할 수 있다.
        {
            _inven.SelectIndex = 100; // 자기 클래스 내부에 있는 다른 클래스일 뿐이다. 공개하지 않으면 못쓴다. 내부에 있어도
        }
    }

    // 어느 방향으로 움직이겠느냐?
    public enum INVENDIR
    {
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN,
    }
    void SelectMove()// 방향을 의미하는 인자값을 넣어야겠는데..//)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        Inven inven = new Inven();
        Inven.INVENDIR invendir = new Inven.INVENDIR();

        inven.InnerClassTest();
        // private 변수를 하위 클래스에서 만든 함수를 통해서 값을 변경할 수 있다. 마치 public 변수를 바꾼것처럼
        // 이런걸 inner class라고 부름
        
    }
}