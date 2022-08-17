


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


    /// <summary>
    /// 리스트가 비어있으면 Head에 새 노드를 할당한다.
    /// 비어있지 않으면 마지막 노드를 찾아 이동한 후 마지막 노드 다음에 새 노드를 추가한다.
    /// </summary>
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

    /// <summary>
    /// AddAfter();
    /// 새 노드의 Next에 현재 노드의 Next를 현재 노드의 Next를 먼저 할당하고 현재노드의 Next에 새노드를 할당한다.
    /// (Current에 NewNode를 연결)
    /// </summary>
    public void AddAfter(SinglyLinkedListNode<T> _Current, SinglyLinkedListNode<T> _NewNode)
    {
        if (Head == null || _Current == null)    
        {
            return;
        }
        _NewNode.Next = _Current.Next;
        _Current.Next = _NewNode;
    }
    
    /// <summary>
    /// 노드를 하나 삭제하고싶다면.. 삭제할 노드가 첫노드인지 아닌지 확인한후 첫노드면 Head의 다음노드(두번째노드)에게
    /// 헤드를 할당한다. 
    /// 첫노드가 아니라면, 지우고싶은 노드를 검색해야하는데 단일연결리스트이므로 단방향으로 검색한다. 
    /// 반복문으로 삭제할 노드의 바로 이전노드를 찾아서 이전노드의 Next에 삭제노드의 Next를 할당한다.
    /// 
    /// 앞에있는 노드의 넥스트가 삭제하고싶은 노드의 넥스트가 되게하면 앞에있는 노드의 넥스트가 삭제 다음 노드를 가르키게되는 원리
    /// </summary>
    
    public void Remove(SinglyLinkedListNode<T> _RemoveNode)
    {
        if (Head == null || _RemoveNode == null)
        {
            return;
        }
        if (_RemoveNode == Head)
        {
            Head = Head.Next;
            _RemoveNode = null;
        }
        else
        {
            var current = Head;
            while (current!=null && current.Next!=_RemoveNode)  
            {
                current=current.Next;
            }
            if (current!=null)
            {
                current.Next = _RemoveNode.Next;
                _RemoveNode = null;
            }
        }
    }
    /// <summary>
    /// GetNode();
    /// 단일 연결 리스트에서 특정 위치에 있는 인덱스노드를 리턴하고싶다면 이 함수를 씁니다.
    /// 만약 인덱스가 연결리스트범위를 벗어나면 null 을 리턴합니다.
    /// 배열은 인덱스를 통해 즉시 배열요소를 찾을 수 있지만 링크드리스트는 해당 인덱스 만큼 계속 이동해서 확인하는 절차가 필요합니다.
    
    /// </summary>
    
    public SinglyLinkedListNode<T> GetNode(int index)
    {
        var current = Head;
        for (int i = 0; i < index && current!=null; i++)
        {
            current = current.Next;
        }
        return current; 
    }

    /// <summary>
    /// Count();
    /// Head부터 마지막 노드까지 이동하면서 카운트를 1씩 증가시키는 변수를 만들고 그숫자를 리턴
    /// </summary>
    /// <returns></returns>

    public int Count()
    {
        int count = 0;
        var current = Head;
        while (current != null) 
        {
            count++;
            current = current.Next;
        }
        return count;
    }
}
class Program
{
    
    static void Main(string[] args)
    {
        var list = new SinglyLinkedList<int>(); // 정수형 객체를 만듬. 이 객체는 인트형의 새로운 싱글링크드리스트

        for (int i = 0; i < 5; i++)
        {
            list.Add(new SinglyLinkedListNode<int>(i)); // i를 벨류로 갖는 단일 링크드 리스트 노드임
        }
        //index가 2인 요소를 삭제하고싶다.
        var node = list.GetNode(2);
        list.Remove(node);
        //index가 1인 요소가져오기
        list.GetNode(1);
        //index가 1인 요소 뒤에 100을 삽입
        list.AddAfter(_Current: node,new SinglyLinkedListNode<int>(100));
        //리스트 카운트 체크
        int count = list.Count();
        //전체 출력
        for (int i = 0; i < count; i++)
        {
            var n = list.GetNode(i);
            Console.WriteLine(n.Data);
        }

    }
}