using System.Diagnostics;
// double linkedListImplementation
namespace D_LinkedListImpImplementation
{
    class Program
    {


        class DLinkedListNode // 연결리스트는 노드의 연결이기 때문에 노드가 무엇인지 정의해준다// 클래스를 만들어서 링크드리스트노드가 무엇인지 정의해줌 
        {
            public int data; // 데이터값을 저장할 변수를 만들어줌
            public DLinkedListNode next; // 맴버 변수 next, LinkedListNode 클래스를 참조함
            public DLinkedListNode prev; // 맴버 변수 prev, LinkedListNode 클래스를 참조함
            public DLinkedListNode(int x) // 외부에서 x 값을 받음 LinkedListNode 클래스를 참조함
            {
                data = x; // 외부에서 받은 x는 LinkedListNode의 data임
                next = null; //node의 next와 prev를 null로 리터럴 초기화함
                prev = null;
            }

        }

        class DLinkedList // LinkedList 클래스를 만들어 LinkedList가 무엇인지 정의 해준다.
        {
            int count;
            DLinkedListNode head; // 만들어논 
            DLinkedListNode tail;

            public DLinkedList() // 생성자를 만들어서 객체를 만들어줌
            {

                head = null;
                count = 0;
                tail = null;
            }
            public void AddNodeToFront(int data) // 새로운 노드를 추가할 때는 링크드리스트의 앞부분에 헤드로 연결되기 때문에 헤드에 새로운 노드가 연결되는 메서드를만든다.
            {
                DLinkedListNode Newnode = new DLinkedListNode(data);

                if (count < 1)
                {
                    head = Newnode;
                    tail = Newnode;
                }
                else // if (count >= 1)
                {
                    head.prev = Newnode;
                    Newnode.next = head;
                    head = Newnode;
                }
                count++; // 노드를 추가할때 마다 카운트가 1씩 증가
            }

            public void AddNodeToRear(int data) // 새로운 노드를 추가할 때는 링크드리스트의 앞부분에 헤드로 연결되기 때문에 헤드에 새로운 노드가 연결되는 메서드를만든다.
            {
                DLinkedListNode node = new DLinkedListNode(data);
                //연결하고 테일을 옮기면됨
                // 코드가 3개 필요함
                // 1. 기존의 노드에서 새로생긴 노드로 연결
                // 2. 새로생긴 노드에서 기존의 노드로 연결
                // 3. tail을 새로생긴 노드로 옮기는 작업
                if (count > 1)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.next = node;
                    node.prev = tail;
                    tail = node;
                }
                node.next = tail;
                node.prev = tail;
                tail = node; // 헤드가 새로운 노드를 가르키도록 정의해준다.
                count++; // 노드를 추가할때 마다 카운트를 증가실킬 수 있다. 
            }

            public void RemoveToFront()
            {
                if (head == null)
                {
                    Console.WriteLine("no");
                }

                else if (count == 1) // 한개만남은경우 - 클리어 매서드 만들어서 쓰는거 해봐야함
                {
                    // head and tail 모두  null 이 되어야함
                    head = null;
                    tail = null;
                    count = 0;
                }
                else // 한개 초과해서 남은 경우
                {
                    head = head.next;
                    head.prev = null;
                    count--;
                }
            }
            public void RemoveToLast()
            {
                if (tail == null)
                {
                    Console.WriteLine("no");
                }

                else if (count == 1) // 한개만남은경우 - 클리어 매서드 만들어서 쓰는거 해봐야함
                {
                    // head and tail 모두  null 이 되어야함
                    head = null;
                    tail = null;
                    count = 0;
                }
                else // 한개 초과해서 남은 경우
                {
                    tail = tail.prev;
                    tail.next = null;
                    count--;
                }
            }
            public void PrintList() // 추가된 노드를 확인하기 위해서 연결리스트를 출력하는 매서드를 만든다.
            {
                DLinkedListNode runner = head; // 추가할 때마다 반복적으로 프린트하기위해서 while반복문을 사용한다. head가 null이 아니면 반복하므로 변수 runner를 만들어서 헤드를 의미하도록한뒤 
                while (runner != null) // 반복문을 만든다.
                {
                    Console.WriteLine(runner.data); // 추가된 데이터를 출력한다.
                    runner = runner.next; // 추가된 헤드로 이동
                }
            }
            public void PrintReversList() // 추가된 노드를 확인하기 위해서 연결리스트를 출력하는 매서드를 만든다.
            {
                DLinkedListNode runner = tail; // 추가할 때마다 반복적으로 프린트하기위해서 while반복문을 사용한다. head가 null이 아니면 반복하므로 변수 runner를 만들어서 헤드를 의미하도록한뒤 
                while (runner != null) // 반복문을 만든다.
                {
                    Console.WriteLine(runner.data); // 추가된 데이터를 출력한다.
                    runner = runner.prev; // 추가된 헤드로 이동
                }
            }
            public void PrintCount()
            {
                Console.WriteLine(count);
            }
        }
        static void Main(string[] args)
        {
            DLinkedList dLinked = new DLinkedList();

            dLinked.AddNodeToFront(10);
            dLinked.AddNodeToFront(11);
            dLinked.AddNodeToFront(12);
            dLinked.AddNodeToFront(13);
            dLinked.PrintList();
            Console.WriteLine("--------------");
            dLinked.PrintReversList();
            dLinked.RemoveToLast();
            Console.WriteLine("--------------");
            dLinked.PrintList();
        }







    }
}