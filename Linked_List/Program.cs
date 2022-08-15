
// 리스트형 자료구조와 링크드 리스트의 차이

// ==시퀀스형 자료구조 와 시퀀스 노드형 자료구조의 차이 ==
 
// 배열(연결을 끊을 수 없음 시퀀스 배열형)은 중간에 뭘 빼내는 작업이 번거롭지만 
// 시퀀스 노드형 (링크드리스트) 는 중간을 지울수도 있고 넣을 수도 있다.
// 하지만 처음부터 자료를 쭉 돌아다녀야 함  


class Program
{
    //class Node<T>
    //{
    //    
    //    public Node<T> Next;
    //    public Node<T> prev;
    //}
    //class MyLinkedList<T>
    //{
    //    public Node<T> First;
    //    public Node<T> Last;
    //}
    static void Main(string[] args)
    {
        LinkedList<int> list = new LinkedList<int>();
        //LinkedList<int> (노드를 생성관리하는 제네릭)
        //list.AddFirst = 가장 앞에 붙인다.
        //list.AddLast = 가장 뒤에 붙인다.

        // 추가하는 함수
        list.AddLast(1);
        list.AddFirst(2);

        // 앞에 추가하는 함수
        list.AddFirst(10); 
        list.AddFirst(20);
        //// 지우는 함수
        list.Remove(10);
        list.Remove(list.First);


        LinkedListNode<int> Cur = list.First;
        // 여기에 Cur 변수는 LinkedListNode<int>를 참조하는 노드를 가리킨다.
        // using.System.Collections.Generic.LinkedList<int>가 미리 만들어놓은
        // 제네릭을 객체화 해서 만들어진 변수 list의 첫번째 노드를 이 노드로 대입한다.

        for (LinkedListNode<int> startNode = list.First; null != startNode;
            startNode = startNode.Next)
        {
            Console.WriteLine(startNode.Value);
        }
        // 반복문을 만들어서 프린트하려고한다. 
        // 반복문의 초기값을 startNode 변수로 지정, 이 변수는 첫번째 list객체의 첫번째 값으로 설정
        // startNode는 LinkedListNode 클래스의 int형 값인데 이 값이 없는경우까지 반복한다.
        // 초기값 startNode가 null이 아니다 라는 명제가 참인지 거짓인지 확인한 후 참이면
        // startNode의 값을 콘솔에 프린트한다.
        // 이 연산이 끝나면 startNode는 startNode의 next로 대체된다.
        // startNode의 값이 null일때까지 반복한다.

        for (LinkedListNode<int> startNode = list.Last; null != startNode;
            startNode = startNode.Previous)
        {
            Console.WriteLine(startNode.Value);
        }
        //위에 작업을 거꾸로 해서 출력


        // 노드관리자 LinkedList<int>에 Cur 라는 변수를 만들고 그곳을 커서놓는 곳으로 정해줌
        //Cur = Cur.Next;
        //list.AddAfter(Cur, 999999);
        

        
        
    }
}






