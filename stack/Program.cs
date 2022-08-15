
// 제한적으로 접근할 수 있는 나열 구조
// 언제나 목록에 끝에서만 접근 가능 
// 선형구조 

//  > 참조  >> 할당

// Push
// 1. 스텍이 비어있다면
// 2. 새 노드를 만들어  top(head,tail개념) 을 할당
// 3. 스텍이 비어있지 않다면, 새노드를 만들어 node.next에 top을 할당
// 4. 추가된 노드가 top이 됨

// Pop
// 1. 스텍이 비어있으면 (top == null) 스텍이 비어있다고 출력
// 2. 스텍이 비어있지 않으면 top의 데이터를 맴버 변수 _data에 저장
// 3. top = top.next; 로 탑을 변경
// 4. return _data;

// Peek
// 1. Pop에서 3번만 빼면 Peek 임



class Node
{
    public int data;
    public Node next;
    public Node(int _data)
    {
        data = _data;
    }
}
class Stack
{
    public void Push(int _data)
    {
        if ( == null)
        {
            this.top = new Node(_data);
        }
        else
        {
            Node node = new Node(_data);
            Node.next = top;
            top = Node;
        }
    }
}





