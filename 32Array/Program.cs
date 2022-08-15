class Program
{
    class Item
    {
        public string Name;
        public int AT;
        public int DF;
    }

    static void Main(string[] args)
    {
        // 배열은 기본자료형이다. 
        // 선언방식은
        // 어떤 자료형 []
        // 모든 자료형은 구조체 아니면 클레스다
        // 맴버 변수와 맴버 함수가 있다는 말임
        // 기본자료형도 그렇다.

        int[] arrint = new int[10]; // [0][0][0][0][0][0][0][0][0][0]
        
        // array는 인트의 배열형이다.
        // array[0]은 무슨 자료형인가? 인트형이다.
        Console.WriteLine(arrint[0]);

        for (int i = 0; i < arrint.Length; i++) // Length는 프라퍼티
        {
            Console.WriteLine(arrint[i]);
        }

        // 배열의 특징
        // 1. 여러개가 모여있다. = 
        // 2. 순서대로 있다.
        // 3. 접근방법이 인덱스순서로 접근한다.

        //배열을 쓰는 경우
        //1. 

        // 클래스는 배열이 될 수 있을까? 클래스도 자료형 = 사용자 정의 자료형 int는 기본자료형 둘다 자료형이므로 배열이 될 수 있다.
        // 값 형(int)은 만들자마자 실제 메모리소모하는 것이 10개 생기지만
        // 레퍼런스 자료형(클래스)같은것은 참조할수 있는 공간이 10개 생긴거임  new 레퍼런스 () ;이렇게 참조하는 생성자를 만들어줘야됨

        Item [] ArrItem = new Item [10];
        for (int i = 0; i < ArrItem.Length; i++)
        {
            ArrItem [i] = new Item();
        }

        ArrItem[0].Name = "철 검";
        ArrItem[1].Name = "전설의 검";
        ArrItem[2].Name = "갑옷";
        ArrItem[3].Name = "멋진 갑옷";
        ArrItem[4].Name = "포션";

        for (int i = 0; i < ArrItem.Length; i++)
        {
            Console.WriteLine(ArrItem[i].Name);
        }
        // xxxx*******
        // ***********
        // ***********






    }
}