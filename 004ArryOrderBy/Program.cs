
public static class Extensions
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
}
class Program
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

//더 해볼수있는것들.

//1. 6개짜리 배열이 생기고 뒤에
//2. 7개의 인덱스가 있는 배열을 다시 만든다

//3.그 배열로 자료를 옮긴다.
//4.마지막에 추가된 값을 정렬해서 출력한다.

//5.사용자가 숫자를 더추가하고 싶으면 1번을 누르고 프로그램을 종료하고 싶으면 2번을 누른다. 

//6. 1번을 누르면 마지막에 출력된 배열에서 한개 더 긴배열을 갖는 새로운 배열을 만든다.

//7.새로운 배열에 사용자가 입력한 값이 마지막에 추가되게 만든다.

//8.새로 만든 배열을 출력한다.




    }
}