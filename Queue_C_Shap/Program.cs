
class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        while (queue.Count() > 0 )
        {
            Console.WriteLine(queue.Dequeue());
        }
        
    }
}

public class Queue
{
    LinkedList<int> queue = new LinkedList<int>();

    public void Enqueue(int value)
    {
        queue.AddLast(value);
    }
    public int Dequeue()
    {
        if (queue.Count <= 0)
        {
            return -9999;
        }
        int tmp = queue.First.Value;
        queue.RemoveFirst();
        return tmp;
    }
    public int Peek()
    {
        if (queue.Count <= 0)
        {
            return -9999;
        }
        int tmp = queue.First.Value;
        return tmp;
    }
    public int Count()
    {
        int count=0;

        for (int i=0; i<queue.Count; i++)
        {
            count++;
        }
            
        return count;
    }
}


