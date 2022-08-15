
// Array = 형식이 동일한 변수를 여러개 저장 하는 메모리 저장 구조
// int number 0; int number 1; int number 2;
// int [] number = new int [3]
// int = 0; , string = 'null';


// DynamicArray
// 새로운 요소가 추가될 때 마다 크기를 하나씩 늘리는 것
// 1. 기존 배열의 크기보다 1개 더 큰 임시 배열을 생성
// 2. 임시배열에 기존배열의 모든 요소를 복사
// 3. 임시배열을 기존배열에 할당
// 4. 마지막 인덱스에 요소를 추가 
// 
class Program
{
    static void Main(string[] args)
    {
        DynamicArray dynamicArray = new DynamicArray();
        dynamicArray.AddToLast(30);
        dynamicArray.AddToLast(40);
        dynamicArray.AddToLast(50);
        Console.WriteLine("=========");

        dynamicArray.GetByIndex(0);
        dynamicArray.GetByIndex(1);
        dynamicArray.GetByIndex(2);

        Console.WriteLine("=========");
        dynamicArray.RemoveLast();
        dynamicArray.RemoveLast();

        Console.WriteLine("=========");
        dynamicArray.Count();
    }
}

class DynamicArray
{
    int[] arr = new int[2];

    int cur = 0;

    public void Print()
    {
        for (int i = 0; i < cur; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }


public void AddToLast(int _data)
    {
        arr[cur++] = _data;
        
        if (cur >= arr.Length)           
        {
            int[] temp = new int[arr.Length*2];
           
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
        }
    }
    public void RemoveLast()
    {
        cur--;
        if (cur < 0)
        {
            cur = 0;
        }
    }
    public int Count()
    {
        return cur;
    }

    public int GetByIndex(int index)
    {
        if (index < 0)
        {
            return -9999;
        }
        else if (index >= arr.Length)
        {
            return -9999;
        }
        
        else
        {
            return arr[index];
        }
    }
}





