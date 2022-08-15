/* Part1 = 문법과 개념 설명을 따로 파트원에 담았다 왜냐하면 예외처리가 항상들어가므로 클래스로 담아서 쓰는것이 보통이기때문이다. 
    static void Main(string[] args)
    {
        // Dictionary = 제네릭이 두개인 애, 자료 검색에 특화된 데이터 구조
        // string을 키 라고 하고 int는 value라고 함
        // 해쉬라는 개념이 이것에 해당함

        // 감자튀김 500원 햄버거 1000원 

        Dictionary<string, int> map = new Dictionary<string, int>();
        map.Add("I am number one", 1);
        map.Add("I am number two", 2);
        map.Add("What am I?", 99999);
        map.Add("McDonald buger", 9);
        map.Add("McDonald buger2", 9);


        // 같은 키를 두번 넣어주는 것은 불가능
        //그래서 중복을 막는 방어코드를 아래와 같이 써준다.
        if (false == map.ContainsKey("I am number one"))
        {
            Console.WriteLine("I am number one");
        }
        

        // 배열형이기 때문에 string(키) = 인덱서로 쓸수 있음
        Console.WriteLine(map["I am number one"]);
        // 바로 키를 넣어서 지우기도 가능
        map.Remove("What am I?");


        // Console.WriteLine(map["I am number three"]); 
        // will be exception 왜냐 딕셔너리에 등록이 안되있으니까


        //dictionary는 탐색에 특화되어있기 때문에 아래와같은 것도 가능
        string Key = "McDonald buger";
        if (map.ContainsKey(Key))
        {
            Console.WriteLine(Key);
        }

    }
    */

// part2 = Implemetation
class DicTest
{
    private Dictionary<string, int> NewDic = new Dictionary<string, int>();
    
    public void Add(string _Name, int _Value)
    {
        if (true == NewDic.ContainsKey(_Name))
        {
            return; // 키가 같은 노드가 있으면
        }
        NewDic.Add(_Name, _Value); // 키가 없을 때만 값이 들어감
    }

    public void Print(string _Name)
    {
        if (false == NewDic.ContainsKey(_Name))
        {
            return; // 키가 같은 노드가 있으면
        }
        Console.WriteLine(NewDic[_Name]);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DicTest NewTest = new DicTest();
        NewTest.Add("ha", 1);
        NewTest.Add("haha", 2);
        NewTest.Add("hahaha", 3);
        NewTest.Add("haha", 5);

        NewTest.Print("ha");
    }
}



