public class StackUsingArray
{
    private object[] array;
    private int top;
    private void ResizeStack()
    {
        int capacity = 2 * array.Length;
        var tempArray = new object[capacity];
        Array.Copy(array, 0, tempArray, 0, array.Length);
        array = tempArray;
    }

    public StackUsingArray(int capacity = 16)
    {
        array = new object[capacity];
        top = -1;
    }
    public bool IsEmpty
    {
        get { return top == -1; }
    }
    public void Push(object data)
    {
        if(top == array.Length - 1)
        {
            ResizeStack();
        }
        array[top++] = data;
    }
    public object Pop()
    {
        if (this.IsEmpty)
        {
            Console.WriteLine("Empty");
        }
        return array[top--];
    }
    public object Peek()
    {
        if (this.IsEmpty)
        {
            Console.WriteLine("Empty");
        }
        return array[top];
    }
}



public class StackUsingLinkedList<T>
{
    private class Node
    {
        public object Data { get; set; }
        public Node Next { get; set; }
        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }
    private Node top = null;
    public bool IsEmpty
    {
        get { return top == null; }
    }
    public void Push(object data)
    {
        if(top == null)
        {
            top = new Node(data);
        }
        else
        {
            //노드추가
            var node = new Node(data);
            node.Next = top;
            top = node;
        }
    }
    public object Pop()
    {
        if (this.IsEmpty)
        {
            Console.WriteLine("Enmpty");
        }
        object data = top.Data;
        top = top.Next;
        return data;
    }

    public object Peek()
    {
        if (this.IsEmpty)
        {
            Console.WriteLine("Enmpty");
        }
        return top.Data;
    }
}

