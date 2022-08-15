class DynamicArray // Add one by one
{
    private int[] arr = new int[0];

    void Add(int _element)
    {
        int[] temp = new int[arr.Length + 1];
        for (int i = 0; i < arr.Length; i++)
        {
            temp[i] = arr[i];
        }
        arr = temp;
        arr[arr.Length -1] = _element;
    }
}

class DynamicArray2 // extent array length by twice
{
    private int[] arr;
    private const int GROWTH_FACTOR = 2;

    public int Count { get; private set; }
    public int Capacity { get { return arr.Length; } }
    public DynamicArray2(int Capacity = 4)
    {
        arr = new int[Capacity];
        Count = 0;
    }
    public void Add(int _element)
    {
        if(Count >= Capacity)
        {
            int newSize = Capacity * GROWTH_FACTOR;
            int[] temp = new int[newSize];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }
        arr[arr.Length - 1] = _element;
        Count++;
    }
    public int? Get(int index)
    {
        if (index > Count - 1 || index < 0)
        {
            Console.WriteLine("unable to find the element on there. ");
            return null;
        }
        return arr[index];
    }

    public void Remove(int _Element)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == _Element)
            {
                arr[i] = arr[arr.Length + 1];
                arr[i] = arr[i + 1];
            }
        }
        //arr[arr.Length + 1] = _Element;

    }

}
class CircularArray
{
    public void Circulartor()
    {
        char[] A = "abcdefgh".ToCharArray();
        int startIndex = 2;

        for (int i = 0; i < A.Length; i++)
        {
            int index = (startIndex + i) % A.Length;
            Console.Write(A[index]+" ");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        DynamicArray2 dynamicArray2 = new DynamicArray2();
        dynamicArray2.Add(1);
        dynamicArray2.Add(2);
        dynamicArray2.Add(3);
        dynamicArray2.Add(4);

        dynamicArray2.Remove(2);
        //dynamicArray2.Get(-3);
        ////dynamicArray2.Add(99);
        ////dynamicArray2.Get(4);

        ////CircularArray circularArray = new CircularArray();
        ////circularArray.Circulartor();

    }
}

