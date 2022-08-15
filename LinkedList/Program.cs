using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// 배열형과 노드형이 있는데 노드형 전반에 적용되는 내용임 






// 정리.
// 노드 = 자기 클래스 안에 자기자신을 정의해주는 클래스가 있음..

// 노드 클래스의 필드에는 
// T 값을 리턴하는 Data가 필요
// 그리고 next 와 prve 가 있음

// 노드는 자료구조에서만 사용하는 것은 아니다.
// 자료구조라고 치면 여러 자료를 보관해야하므로 제네릭으로 만들어짐
class Node<T>
{
    public T Data;
    // 노드란 자기안에 자기자신을 또 가지는 형태로
    // 되어있는 클래스들을 노드라고 말할 수 있다. 같은형의 레퍼런스를 가짐

    
    public Node<T> Next = null; // 리터럴 초기화를 널로해주니까 if문에서 널이면 빠저나와라 이런거 
                                // 가능하게됨
    public Node<T> Prev = null;
    // 이렇게 표현해주는 이유는 Next, Prev는 힙에 저장되는 메모리를 가리키는 변수이기 때문에
    // 참조형 변수로 만들어짐


    public Node(T _Data) //생성자 만들어서 괄호안에 들어간것이 Data를 참조하게 해준다.
    {
        Data = _Data;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Node<int> Node1 = new Node<int>(10); // 값을 넣어주면 그게 DaTa
        Node<int> Node2 = new Node<int>(999); 
        Node<int> Node3 = new Node<int>(5000);

        Node1.Next = Node2;
        Node2.Next = Node3;
        Node2.Prev = Node1;
        Node3.Prev = Node2;

        Node<int> CurNode = Node1; // CurNode라는 변수는 레퍼런스형 변수지?
                                   // 그러니까 값을 원래 갖는애가 아님 주소에 있는 값을
                                   // 표현하는 애임 (헤드라고 이해할 수 있음) 

        while (CurNode != null)    // 헤드가 널이 아니면 (초기값이 널이고, 루프가 다 돌면 널이되게 선언되어있음)
                                   
        {
            Console.WriteLine(CurNode.Data); // 헤드의 데이터를 프린트하라는 말임
            CurNode = CurNode.Next; // 출력하고 바로 헤드는 출력한 변수에 넥스트
                                    // 즉, Node1.Next = Node2 이므로 Node2가 헤드가 되는 거임 
        }

        Node<int> RCurNode = Node3; // 테일 지정
        while (RCurNode != null)
        {
            Console.WriteLine(RCurNode.Data);
            RCurNode = RCurNode.Prev;
        }

    }
}