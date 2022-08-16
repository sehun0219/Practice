

class GTest<T> // GTest라는 이름의 제네릭 클래스에
               // 어떤 형태든 받을수있는 변수 Data를 만들었다.  
{
    T Data;
}

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> NewDic; // 변수 NewDic는 딕셔너리고
                                              // Key = string, value = List<int> 가 가능하다.

        List<Dictionary<string, int>> NewTest;// 위와 마찬가지로 리스트도 딕셔너리를 참조하는 변수를 
                                              // 만들수 있다.


        List<int> ListTest = new List<int>(); // ListTest는 변수고 int형을 반환한다. 그게 리스트형태로있다.
        LinkedList<int> LinkedListTest = new LinkedList<int>(); // 링크드리스트 를 만듬
        Dictionary<string, int> DicTest = new Dictionary<string, int>();


        ListTest.Add(1);
        ListTest.Add(2);
        ListTest.Add(3);
        ListTest.Add(4);

        Console.WriteLine("=============");

        LinkedListTest.AddLast(1);
        LinkedListTest.AddLast(2);
        LinkedListTest.AddLast(3);
        LinkedListTest.AddLast(4);
        DicTest.Add("one", 1);
        DicTest.Add("two", 2);
        DicTest.Add("three", 3);
        DicTest.Add("four", 4);


        foreach (var item in ListTest)
        {
            Console.WriteLine(item);
        }

        foreach (var item in LinkedListTest)
        {
            Console.WriteLine(item);
        }
        foreach (var item in DicTest)
        {
            Console.WriteLine(item);
        }


        // foreach 는 자동적으로 반복하는 문장으로서
        // in 을 통해서 각 배열이든 딕셔너리든 리스트든 
        // 내부의 자료를 그대로 순회하며 처리합니다.
        // var은 그때의 가장 적합한자료형으로 처리합니다.
        // in은 자료구조에서 빼온다

        // 제어가 불가능하기 때문에 ( 전부다 한번 순회하는 기능만 있음)
        // for 문을 사용하길 추천한다.

        // 하지만 딕셔너리는 foreach를 써서 보는게 편하긴하다.



    }
}
