
class MyClass
{   
    static void Main(string[] args)
    {
        int first = 0;
        int second = 0;
        int inputNum = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();
        
        for (int i = 0; i < inputNum; i++)
        {
            list.Add(int.Parse(Console.ReadLine())); 
        }
        
        for (int i = 0; i < inputNum; i = i+2) 
        {
            
            first= list[i];

            second = int.MinValue;
            if ( i + 1 < inputNum )
                second = list[i + 1];

            Console.Write( Math.Max(first, second) + " ");   
        }
        
    }
}









//int arrLength = int.Parse(Console.ReadLine());
//int[] arr = new int[arrLength];

//int first = 0;
//int second = 0;
//int count = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    int val = int.Parse(Console.ReadLine());
//    first = val;
//    arr[i] = val;

//    count++;
//    if (count % 2 == 0)
//    {

//    }


//}
//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr[i] % 2 != 0)
//    {
//        first = arr[i];
//    }
//    else
//    {
//        second = arr[i];
//    }
//    Console.WriteLine(Math.Max(first, second));
//}