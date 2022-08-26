// Linq는 Language INtegrated Query 의 약자
// 컬렉션형태의 데이터를 가공할 때 유용한 메서드를 제공한다.

// 배열 또는 리스트 등 컬렉션 데이터를 반복문과 조건문을 사용하여 쉽게 구할 수 있다.
// 닷넷에서는 특정 형식에 원래는 없던 기능을 덧붙이는 개념으로 확장 메서드를 제공한다.
// 예를 들어 정수 배열의 합을 구하려면  if문과 for문을 사용해서 직접 합계 기능을 구현해야한다. 하지만 확장 메서드 개념으로
// 없는 기능을 추가할 수 있다. 

// 확장메서드를 사용하려면 system.Linq 네임 스페이스를 선언해야한다. 

// 기억해야할 중요한 메서드들은 배열 또는 컬렉션에서
// sum, count, average, max, min 같은 것들이다.

class LinqSum
{
    static void Main()
    {
        int[] num = {1, 2, 3 };
        int min = num.Min();
        Console.WriteLine(min);


        Func<int, bool> isEven = x => x % 2 == 0;
        Console.WriteLine(isEven(2));


        int[] numbers = {1, 2, 3, 4, 5};
        IEnumerable<int> newNumbers = numbers.Where(number => number > 3);
        foreach (var n in newNumbers)
        {
            Console.WriteLine(n);
        }

        List<int> list = numbers.Where(numbers => numbers > 3).ToList();
        foreach (var x in list)
        {
            Console.WriteLine(x);
        }
    }
}