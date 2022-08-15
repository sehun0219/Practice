using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// === 코딩의 기본 ===
// if 문이나 switch 문으로 검사할 수 있다면 검사하고 사용한다

// 논리회로 
// 아이템을 담아두는 인벤토리를 만들겠다. 
// 1. 인벤토리가 최대 몇개를 담을 수 있는지 정해야겠죠?
// 2. 이 때 한줄로 쭉 만들건지 아니면 여러줄로 생긴 표처럼만들것인지 정해야죠? (x축과 y축)
// 3. 생성자를 만들어서 실제 메모리 값을 할당함과 동시에 인자를 x 와 y를 써서 만들어줘야겠죠?

class Inven
{
    int SelectIndex = 0;
    Item[] ArrItem;
    int ItemX;
    

    public Inven(int _X, int _Y) // 들어오는 값들을 체크해서 문제가 없게 만드는 코드
    {
        if (1 > _X) // 방어코드 // 초보프로그래머가 가장 주의해야할 것은 방어코드를 작성하는겁니다.
        {           // 방어코드란 // switch의 디폴트처럼 함수를 짤때 나만의 예외발생시 어떻게 된다는 코드를 해줘야합니다.  
            _X = 1;
        }
        if (1 > _Y)
        {   
            _Y = 1;
        }
        ItemX = _X;
        
        ArrItem = new Item[(_X * _Y)];
    }

    // 각종 기능들 방향키움직이면 인덱스를 선택하게 되고
    // 그 이름과 가격이 아래에 출력되게 만들기
    // 빈곳이 선택되면 없다고 출력
    public void AddItem(Item _Item, int _Order)
    {
        // null 방어코드
        if (null != ArrItem[_Order]) // 뭔가 있는곳이면 못넣는다
        {
            return;
        }
        // 방어코드 만들어보기
        if (_Order < 0)
        {
            return;
        }//(_Order > ArrItem.Length)
        ArrItem[_Order] = _Item;
    }
    public bool OverCheck(int _SelectIndex) // 셀렉트 인덱스가 화면 밖으로 넘어갔는가?
    {
        return false;
    }
    public void selectMoveLeft()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= 1;
        if (OverCheck(CheckIndex))
        {
            return ;
        }
        SelectIndex -= 1;
    }
    public void selectMoveRight()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += 1;
        if (OverCheck(CheckIndex))
        {
            return;
        }
        SelectIndex += 1;
    }
    
    public void selectMoveUp()
    {
        int CheckIndex = SelectIndex;
        CheckIndex -= ItemX;
        if (OverCheck(CheckIndex))
        {
            return;
        }
        SelectIndex -= ItemX;
    }
    public void selectMoveDown()
    {
        int CheckIndex = SelectIndex;
        CheckIndex += ItemX;
        if (OverCheck(CheckIndex))
        {
            return;
        }
        SelectIndex += ItemX;
    }


    public void Render()
    {
        for (int i = 0; i < ArrItem.Length; i++)
        { 
            // ★★★□□ 
            // □□□□□  
            // □□□□□   이런모양으로 하고싶은데..?
            // ItemX가 0이 아니면서 5로 나눴을 때 나머지가 0이면 한줄 내려가라
            if (0 != i && 0 ==i % ItemX)
            {
                Console.WriteLine(" ");
            }
            // 선택된 인덱스는 ◈ 로 표시하기
            if (SelectIndex == i)
            {
                Console.Write("◈");
            }
            // 15개의 아이템을 가질 수 있는 인벤에 i인덱스에 아이템이 있냐?
            if (null == ArrItem[i])
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("★");
            }
         }
        Console.WriteLine(" ");
        if (ArrItem[SelectIndex] != null)
        {
            Console.WriteLine("현재 선택한 아이템");
            Console.WriteLine("이름 : " + ArrItem[SelectIndex].Name);
            Console.WriteLine("이름 : " + ArrItem[SelectIndex].Gold);
        }
        else
        {
            Console.WriteLine("비어있음");
        }

        
    }
    public void AddItem(Item _Item) // 아이템을 넣는데 널인에 아이템을 인벤에 추가하는 함수 // 
    {
        int Index = 0;
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if  (null == ArrItem[i])
            {
                Index = i;
                break;
            }
        }
        ArrItem[Index] = _Item; 
    }
}
