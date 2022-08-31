// field 필드는 클래스의 부품 역할을 하는 클래스의 내부 상태값을 저장하는 그릇이다.

// 클래스 내에서 선언된 변수 또는 배열을 필드라고 부른다. 
// 필드는 클래스의 부품역할을한다.
// 대부분 private 한정자가 붙는다.
// 개체의 상태를 보관한다.
// 필드는 초기화하지 않아도 자동으로 초기화 된다. int는 0이고 string은 공백으로 초기화 된다.


// 지역변수와 전역변수
// 변수를 선언할 때는 매서드 내에서 하거나 매서드 밖에서 매서드와 동등한 레벨에서 변수를 선언 할 수 있다.
// 매서드 밖에서 선언되면 전역변수 global 
// 매서드 안에서 선언되면 지역변수 loca 이라고 부른다. 여기서 전역변수가 필드다.

// 지역변수
// 지역변수는 Main 메서드가 종료되면 자동으로 소멸한다. 

/*// 지역변수 3개 선언하고 더하기

class LocalVariable
{
    static void Main(string[] args)
    {
        int i = 1234, j = 2345, k = 3456;
        Console.WriteLine(i + j + k);
    }
}*/

// 필드 
// C샵에서는 필드를 소문자로 쓰거나 _언더스코어로 시작한다.

/*
class MyClass
{
    static string gv = "전역변수";
    static void Test()
    {
        Console.WriteLine(gv);
    }
    static void Main(string[] args)
    {
        string lv = "지역변수";
        Console.WriteLine(gv);
        Console.WriteLine(lv);
        Test();
        
    }
}*/

// 필드의 종류 
// 변수 variable
// 상수 constant
// 읽기전용 readonly
// 배열 array
// 기타 개체 모든 데이터형식의 변수

// 필드 이니셜라이저 사용

//class Say
//{
//    private string _message = "안녕하세요"; // 초기선언은 안녕하세요지만
//    public void Hi()
//    {
//        this._message = "반갑습니다."; // 다시 정의해서 사용가능
//        Console.WriteLine(this._message);
//    }
//}
//class FieldInitializer
//{
//    static void Main(string[] args)
//    {
//        Say say = new Say();
//        say.Hi();
//    }
//}

// 배열형식의 필드 사용

//class Schedule
//{
//    private string[] _weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
//    public void PrintWeekDays()
//    {
//        foreach (var item in _weekDays)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}
//class FieldArray
//{
//    static void Main(string[] args)
//    {
//        Schedule schedule = new Schedule();
//        schedule.PrintWeekDays();
//    }

//} // 이처럼 필드에는 변수, 배열 등 데이터 구조가 올수 있다.

// 엑세스 한정자
// 필드를 만들고 외부에서 사용하도록 하려면 public 액세스 한정자를 쓰거나 property로 변환시켜야한다.

// 클래스와 클래스 간 멤버에 접근할 때는 한정자를 씁니다.
// 디폴트 값은 private 
// public  제한 없이 접근 가능
// private 현재 클래스 내에서만 접근 가능
// protected 현재클래스 또는 현재클래스를 상속하는 자식클래스에 접근이 허용. 
// internal 프로젝트 모든 클래스에 접근허가
// protected internal 현재 어셈블리 또는 어셈블리에 파상된 모든 클래스에 액세스가 허가됩니다. 
namespace FieldNote
{
    class Person
    {
        private string name = "김세훈";
        private const int m_age = 37;
        private readonly string _NickName = "redplus";
        private string[] _website = { "닷넷코리아", "깃허브" };
        private object all = DateTime.Now.ToShortTimeString();
        public void ShowProfile()
        {
            string r = $"{name}, {m_age}, {_NickName}, {String.Join(",", _website)}"
                     + $"{Convert.ToDateTime(all).ToString()}";
            Console.WriteLine(r);
        }
    }
    class FieldNote
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ShowProfile();
        }
    }

}