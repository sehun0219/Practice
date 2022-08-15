
class IndexValue
{
    public void PutInValue(int[] arr)
    {
        Random NewRandom = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            int randomValue = NewRandom.Next(5);
            arr[i] = randomValue;
        }
    }

}
// 오래걸릴것같은..
class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];

        IndexValue indexValue = new IndexValue();
        indexValue.PutInValue(arr);
        Console.WriteLine("배열에 입력된 랜덤숫자들을 출력합니다.");
        Console.WriteLine(string.Join(" ",arr));

        Console.WriteLine("중복된 값을 정리하고 다시 출력합니다.");
        int[] distArray = arr.Distinct().ToArray();
        Console.WriteLine(string.Join(" ",distArray));
    
    }
}