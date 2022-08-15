


// 링크드리스트를 구현하려고한다. 
// 노드가 필요한가 배열이 필요한가 생각해본다.
// 노드가 필요하면 노드를 선언하고 (Data의 기본값은 함수에 인자로 받아씀, next prev 기본값은 null이고)
// 배열이 필요하면 제네릭리스트 만들어서 쓴다. 혹은 배열을 만들어서 쓴다.


public class SinglyLinkedListNode<T> //제네릭 클래스  
{
    public T Data { get; set; }
    public SinglyLinkedListNode<T> Next { get; set; }

    public SinglyLinkedListNode(T _Data)
    {
        this.Data = _Data;
        this.Next = null;
    }
}

public class SinglyLinkedList<T>
{
    private SinglyLinkedListNode<T> Head;
    public void Add(SinglyLinkedListNode <T> _NewNode)
    {
        //리스트가 비어있으면
        if (Head == null)
        {
            Head = _NewNode;
        }
        else
        {
            var current = Head;
            // 마지막 노드로 이동하여 추가
            while(current != null && current.Next != null)
            {
                current = current.Next;
            }
            current.Next = _NewNode;
        }
    }
}
class Program
{
    
    static void Main(string[] args)
    {
        SinglyLinkedList<int> LIST = new SinglyLinkedList<int>();
        LIST.Add(new SinglyLinkedListNode<int>(123));
        LIST.Add(new SinglyLinkedListNode<int>(2123));
        LIST.Add(new SinglyLinkedListNode<int>(1243));
        LIST.Add(new SinglyLinkedListNode<int>(4454));

       
        for (int i = 0; i < 5; i++)
        {
            LIST.Add(new SinglyLinkedListNode<int>(i));
            Console.WriteLine(i);
        }



        //var list = new SinglyLinkedList<int>();
        //for (int i = 0; i < 5; i ++)
        //{
        //    list.Add(new SinglyLinkedListNode<int>(i));
        //}

        //Console.WriteLine(list);
    }
}