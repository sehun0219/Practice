// 원형배열을 사용해 큐 어려워서 일단 냅둠
#region QueueUsingCircularArray
//public class QueueUsingCircularArray
//{
//    private object[] a;
//    private int front;
//    private int rear;
//    public QueueUsingCircularArray(int queueSize = 16)
//    {
//        a = new object[queueSize];
//        front = -1;
//        rear = -1;
//    }
//    public void Enqueue(object data)
//    {
//        if ((rear +1)% a.Length == front) // 큐가 가득차있나?
//        {
//            Console.WriteLine("Full");
//        }
//        else
//        {
//            if(front == -1)
//            {
//                front++;
//            }
//        }
//        //데이터 추가
//        rear = (rear +1)% a.Length;
//        a[rear] = data;
//    }
//    public void Dequeue()
//    {
//        if(front == -1 && rear == -1)
//        {
//            Console.WriteLine("Empty");
//        }
//        else
//        {
//            //데이터 읽기
//            object data = a[front];
//            //마지막 요소를 읽은 경우
//            if (front == rear)
//            {
//                //특수값 -1로 설정
//                front = -1;
//                rear = -1;
//            }
//            else
//            {
//                //Front 이동
//                front = (front +1)% a.Length;

//            }
//            return data;
//        }

//    }
//} 
#endregion // 원형배열을 사용해 큐 어려워서 일단 냅둠

public class Node
{
    public object Data { get; set; }
    public Node Next { get; set; }
    
    public Node (object data)
    {
        Data = data;
        Next = null;
    }
}

public class QueueUsingLinkedList
{
    private Node head = null;
    private Node tail = null;

    public void Enqueue(object data)
    {
        // 노드가 없는경우
        if (head == null)
        {
            head = new Node (data);
            head = tail;
        }
        else
        {
            tail.Next = new Node (data);
            tail = tail.Next;
        }
    }

    public void Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Empty");
        }
        if (head == tail)
        {
            head = tail = null;
        }
        else
        {
            head = head.Next;
        }
    }
}






class Program
{
    static void Main(string[] args)
    {
        // .NET
        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);

        int data = q.Dequeue();
        Console.WriteLine(data);

        foreach (var item in q)
        {
            Console.WriteLine(item);
        }
    }
}