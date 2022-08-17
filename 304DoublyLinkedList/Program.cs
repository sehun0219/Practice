

public class DoublyLinkedListNode<T>
{
    public T Data { get; set; }
    public DoublyLinkedListNode<T> Prev { get; set; }
    public DoublyLinkedListNode<T> Next { get; set; }

    public DoublyLinkedListNode(T _Data) : this(_Data, null, null) { }
    public DoublyLinkedListNode(T _Data, DoublyLinkedListNode<T> _Prev, DoublyLinkedListNode<T> _Next)
    {
        Data = _Data;
        Prev = _Prev;
        Next = _Next;
    }
}

class DoublyLinkedList<T>
{
    public DoublyLinkedListNode<T> head;
    
    /// <summary>
    /// 리스트가 비어있으면 Head에 새노드를 할당
    /// 비어있지 않으면 마지막 노드를 찾아 반복적으로 이동한뒤 새노드를 끝에 붙인다.
    
    public void Add(DoublyLinkedListNode<T> _NewNode)
    {
        if (head == null)
        {
            head = _NewNode;
        }
        else
        {
            var current = head;
            while (current!=null&& current.Next!=null)
            {
                current = current.Next;
            }
            current.Next = _NewNode;
            _NewNode.Prev = current;
            _NewNode.Next = null;
        }
    }
    /// <summary>
    /// 현재노드를 A 새로추가하는 노드를B 현재노드의 다음노드를 C라고 하면 A.next를 B에 연결하고 B.next를 C에 연결한다. 
    /// 레퍼런스만 수정하면 되는 거라서 O(1)임
    
    public void AddAfter(DoublyLinkedListNode<T> _Currnt, DoublyLinkedListNode<T> _NewNode)
    {
        if (head == null || _Currnt == null || _NewNode == null)
        {
            return;
        }
        _NewNode.Next = _Currnt.Next;
        _Currnt.Next.Prev = _NewNode;
        _NewNode.Prev = _Currnt;
        _Currnt.Next = _NewNode;
    }


    /// <summary>
    /// 삭제
    /// 삭제할 노드가 첫노드면 Head의의 다음노드에 헤드를 할당해서 첫노드를 날린다.
    /// 삭제할 노드가 첫 노드가 아니면 삭제할 노드의 이전과 삭제할노드의 다음을 연결한다.
    /// 단일노드는 헤드부터 반복문으로 검색해서 삭제할 노드의 앞노드들 찾아야했지만
    /// 더블링크드리스트는 이전노드와 다음노드를연결할 수 있다.
    /// 
    /// 
    /// </summary>
    /// <param name="_RemoveNode"></param>
    public void Remove(DoublyLinkedListNode<T> _RemoveNode) // 지우려는함수를 인자로 놓고 
    {
        if (head == null || _RemoveNode==null) // 헤드가 널이거나(리스트가 없다는 의미니까) 지우려는게 널값이면 걍 리턴
        {
            return;
        }
        if (_RemoveNode == head)//지우려는 노드가 헤드면
        {
            head = head.Next; // 헤드를 다음노드에 임명
            if (head != null) // 헤드가 널이아니면
            {
                head.Prev = null; // 헤드의 앞부분은 널이어야함
            }
        }
        //첫노드를 지울게 아니면 prev노드와 next노드를 연결해야해
        else
        {
            //지우려는 노드의 앞에있는 노드의 넥스트가 지우려는 노드의 넥스트가 되면됨
            _RemoveNode.Prev.Next = _RemoveNode.Next;
            if (_RemoveNode.Next != null) // 지우려는 노드의 넥스트가 널을 가리키는게 아니라면
            {
                // 지우려는 노드의 넥스트가 프리브가되면됨
                _RemoveNode.Next.Prev = _RemoveNode.Prev;
            }
            
        }
        _RemoveNode = null;
    }

    /// <summary>
    /// 값을 리턴하는거는 인덱스를 0번부터 순차적으로 쭉 확인하면서 같으면 리턴하는 방식이므로 헤드부터 검색해야함
    /// 이중 연결 리스트에서 특정 위치 인덱스에 있는 노드를 리턴한다.
    /// 만약 인덱스가 리스트 범위를 벗어나면 null을 리턴한다.
    public DoublyLinkedListNode<T> GetNode (int index)
    {
        var current = head;
        for (int i = 0; i < index && current != null; i++)
        {
            current = current.Next;
        }
        return current;
    }

    public int Count()
    {
        int count = 0;
        var current = head;
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
        var list = new DoublyLinkedList<int>();
        for (int i = 0; i < 5; i++)
        {
            list.Add(new DoublyLinkedListNode<int>(i));
        }

        // index가 2인 요소 삭제
        var node = list.GetNode(2);
        list.Remove(node);

        // index가 1인 요소 가져오기
        node = list.GetNode(1);

        //index가 1인 요소 뒤에 100 삽입
        list.AddAfter(node, new DoublyLinkedListNode<int>(100));

        //리스트 카운트 체크
        int count = list.Count();

        //전체 출력
        for (int i = 0; i < 5; i++)
        {
            var n = list.GetNode(i);
            Console.WriteLine(n.Data);
        }
    }
}
    