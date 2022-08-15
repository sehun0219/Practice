

class Node
{
    public int data;
    public Node next;

    public Node(int _data)
    {
        data = _data;
    }
}

class Queue
{
    Node head;
    Node tail;

    public Queue()
    {

    }
    public void Enqueue(int _data)
    {
        if(head == null) // 큐가 비어있으면 
        {
            head = new Node(_data); // 새 노드를 만들고 head로 지정
            tail = head; // tail head 모두 새노드에 할당
        }
        else // 큐가 비어있지 않으면
        {
            tail.next = new Node(_data);// 새노드를 만들고 tail 이 가리키는 노드의 넥스트에 새노드를 할당
            tail = tail.next; // 새노드로 테일이 할당되도록 변경
        }
    }
    public int Denqueue()
    {
        if (this.head == null)
        {
            throw new InvalidOperationException("Empty");
        }
        else 
        {
            int _data = head.data; // 헤드의 데이터를 변수 _data에 할당한다.
            if (this.Count() == 1)// 한개밖에 없는경우
            {
                this.head = null; // 헤드와 테일을 널로만들고
                this.tail = null;
            }
            else if (this.Count()>1) //  두개이상일 경우
            {
                this.head = this.head.next; // head.next를 head에 할당해서 앞에껄 지워버림
            }
            return _data; // _data 값을 반환함
        }
    }
    public int Count()
    {
        int count = 0;
        if(head == null)
        {
            return count;
        }
        else
        {
            count = 1; // 비어있지 않으면 카운트를 1 로 바꿈
            Node temp = head; // 노드를 참조하는 변수 temp를 head에 할당 
            while(temp.next != null) // temp 넥스트에 노드가 없을 때까지 반복
            {
                temp = temp.next;
                count++;
            }
            return count;
        }
    }
    public int Peek()
    {
        if(this.head == null)
        {
            throw new InvalidOperationException("Empty");
        }
        else
        {
            int data = head.data; // 헤드가 가리키는 노드의 데이터를 data라는 변수에 저장
            return data; //값 반환
        }
    }


}