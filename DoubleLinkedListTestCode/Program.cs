

// 더블 링크드 리스트 테스트코드
// 

// 1. 노드를 만듬
// 2. 노드가 뭔지 정의해줌
// 
// 3. 더블 링크드 리스트를 만든다.
// 4. 더블 링크드 리스트가 무엇인지 정의해줌

// 5. 메서드들을 만들어줌 (프론트애드,프론트딜리트)


class Program
{
    static void Main(string[] args)
    {

    }
}



class DoubleLinkedList
{
    class Node
    {
        public int data;
        public Node prev = null;
        public Node next = null;
        public Node(int _data)
        {
            data = _data;
        }
    }
    public int count = 0;
    public DoubleLinkedList head = null;
    public DoubleLinkedList tail = null;
    public void AddNodeToFront(int _data)
    {
        DoubleLinkedList node = new DoubleLinkedList();


        if (count == 0)
        {
            head = node;
            tail = node;
        }
        else
        {

        }
    }
}

