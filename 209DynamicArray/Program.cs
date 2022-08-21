
class Program
{
    static void Main(string[] args)
    {
        
        
    }
}

class DynmicArray
{
    int[,] array;
    private const int GrowthFactor = 2;
    private int Count { get; set; }

    private int Capacity { get { return array.GetLength(0); } }
    public DynmicArray(int[,] array, int count)
    {
        this.array = array;
        Count = count;
    }
}