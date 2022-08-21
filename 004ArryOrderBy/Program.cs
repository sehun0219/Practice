// 특정숫자의 배열을 만듬
// 숫자를 입력받음
// 배열을 유지하면서 배열을 늘리고 추가하는 숫자를 넣으면 그숫자가 뒤에 붙음
// 그런데 숫자를 늘리면서 정렬까지 됨


class Array
{

    private int count { get; set; }

    private int value { get; set; }

    public Array() 
    { 
        this.count = count;
        this.value = value;
    }
    public int GetIndexNum(int[] _arr)
    {
        return _arr.Length;
    }

    public void AddIndex(int[] _arr)
    {
        for (int i = 0; i < 6; i++)
        {
            string? num = Console.ReadLine();
            int num2 = Convert.ToInt32(num); 
            _arr[i] = num2;
            count++;
        }
    }

    public int AddValue()
    {
        string val = Console.ReadLine();
        return value = Convert.ToInt32(val);
    }

    public void SortbyAscendingOrder(int[] _arr)
    {

    }
    


}

/*class DynamicArray 
{
    private int[] arr;
    private const int GROWTH_FACTOR = 2;

    public int Count { get; private set; }
    public int Capacity { get { return arr.Length; } }
    public DynamicArray(int Capacity = 4)
    {
        arr = new int[Capacity];
        Count = 0;
    }
    public void Add(int _element)
    {
        if (Count >= Capacity)
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
        arr[arr.Length + 1] = _Element;

    }

}*/






class Program
{
    static void Main(string[] args)
    {
        //1. 다섯개가 들어갈수 있는 배열에 다섯개 숫자를 받아서 정렬한다.
        int[] arr = new int[6];
        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            int input2 = Convert.ToInt32(input);
            arr[i] = input2;
        }
        string val = Console.ReadLine();
        int value = Convert.ToInt32(val);
        
        for (int i = 0; i < arr.Length; i++)
        {
            int cur = arr[i];

            if (value < cur)
            {
                for ( int j = arr.Length - 1; j > i; j-- )
                {
                    arr[j] = arr[j - 1];
                }
                arr[i] = value;
                break;
            }
            
        }

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
        //프린트 배열




        //3. 인덱스 0번부터 값을 리턴해서
        //
        //입력된 숫자와 비교하고 입력된숫자보다 작으면
        //다음인덱스로 가고
        //크면 그 인덱스 앞에 값이되도록 함

        // 뒤에 남아있는 숫자들이오른쪽으로 이동한다.


        //4. 추가로 받은 숫자를 포함해서 다시정렬한뒤 프린트한다.



    }
}













/*public static class Extensions
{
    public static T[] Append<T>(this T[] array, T NewValue)
    {
        if (array == null)
        {
            return new T[] { NewValue };
        }

        T[] result = new T[array.Length + 1];
        for (int i = 0; i < array.Length; i++)
        {
            result[i] = array[i];
        }

        result[array.Length] = NewValue;
        return result;
    }
}*/
/*class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[6];
        
        Console.WriteLine("6개의 인덱스로 이뤄진 배열이 생성되 었습니다. 각 인덱스에 들어갈 숫자를 입력하세요 : " );

        for (int i = 0; i < arr.Length; i++)
        {
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);
            arr[i] = num;
        }

        while (true)
        {
            Console.WriteLine(" ");
            Console.Write("추가할 숫자를 입력하세요 : ");
            int NewInput = Convert.ToInt32(Console.ReadLine());

            int[] result = arr.Append(NewInput);
            Array.Sort(result);
            Console.WriteLine(String.Join(" ", result));

            if (arr.Length == 6)
            {
                arr.Append(NewInput);
                Array.Sort(result);
                Console.WriteLine(String.Join(" ", result));
            }
            
        }
    }
}*/