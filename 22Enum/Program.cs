
//기본자료형 
//int bool...

//사용자정의자료형 
//class - 레퍼런스형
//struct - 값형 
//enum - 값형


// 결국 프로그램이란 램을 변경하는 작업 이니까 램이 어떻게 변하는지
// 이해하면서 사용해야함



//enum이란 (열거자)
//보통 어떤 상태를 표현하는것 중 나만의 것을 가지고 싶을 때 사용함
//다른언어에서는 정수형 상수라고 하는데 C#은 그냥 상수임
//값형이고, int 처럼 사용가능함

enum ItemType
{
    //내가 값의 범위를 지정한 새로운 자료형을 만들어 낼 수 있다.
    // swich와 궁합이 좋다.
    Equip,
    Potion,
    Quest
}


class Item // 일일이 장비,포션,퀘스트아이템 이런식으로 다 클래스를 만들어서 쓰지 않음
{
   //int ItemType = 0; // 이렇게 해노면 가독성이 너무 떨어짐.. 0이 뭐임? 
                       // 이때 enum 을 사용함

    public ItemType ItemType = ItemType.Equip;

}

class Program
{
    static void Main(string[] args)
    {
        Item item = new Item();
        item.ItemType = ItemType.Potion;
        
        // switch 문이랑 가장어울림 이렇게 할수 있음
        ItemType Type = ItemType.Potion;
        switch (Type)
        {
            case ItemType.Equip:
                break;
            case ItemType.Potion:
                break;
            case ItemType.Quest:
                break;
            default:
                break;
        }
    }
}