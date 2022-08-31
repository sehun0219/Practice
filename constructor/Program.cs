//

// C#에서 생성자는 클래스에서 맨 먼저 호출되는 메서드다.
// 클래스 기본값 등을 설정하는 역할을한다.
// 자동차의 시동걸기가 바로 생성자다.

// 클래스의 구성요소로 생성자라는 메서드가 있다.
// 단어 그대로 개체를 생성하면서 무엇인가 하고자 할때 사용되는 메서드다.
// 일반적으로 생성자는 개체를 초기화(클래스 안의 필드들을 초기화) 할때 사용된다.
// 규칙
// 생성자는 이름이 클래스와 같다.
// 클래스 내에서 클래스의 이름과 동일한 이름을 갖는 메서드는 모두 생성자다.

// 생성자는 매개변수가 없는 생성자가 있고 매개변수가 있는 생성자가 있다.
// 반환값은 가지지 않는다. 
// static생성자와 public 생성자가 있다. 

// 생성자 코드
// Car클래스 내에 Car()란 인스턴스 생성자를 만든다.
// 반환값이 없고 메서드와 동일하게 어떤 기능을 수행하는데 주로 멤버의 값들을 초기화 한다. 

//class Car
//{
//    public Car() // 매개변수가 없는 기본생성자
//    {
//        Console.WriteLine("Constructor");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car();
//    }
//}

//class Student
//{
//    public Student() { Console.WriteLine("Student 개체가 생성된다."); }
//    // 생성자도 함수다. 모든 클래스는 적어도 생성자 하나를 갖는다. 단 사용하지 않는 기본생성자는 코드에서 생략된다.
//}
//class ConstructorMethod
//{
//    static void Main(string[] args)
//    {
//        Student student = new Student();
//    }
//}

//public class Dog
//{
//    private string _name;
//    public Dog(string name)
//    {
//        this._name = name;
//    }
//    public string Cry()
//    {
//        return _name + "이(가) 멍멍";
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Dog dog1 = new Dog("Disco");
//        dog1.Cry();
//        Dog dog2 = new Dog("Buggu");
//        dog2.Cry();
//        Console.Write(dog1.Cry() +" " + dog2.Cry()) ;
//    }
//}

// 매개 변수가 여러개인 생성자 만들기

//namespace ConstructorParameter
//{
//    class My
//    {
//        private string _name;
//        private int _age;
//        public My(string name, int age)
//        {
//            this._name = name;
//            this._age = age;
//        }
//        public void PrintMy()
//        {
//            Console.WriteLine($"이름: {this._name}, 나이: {this._age}");
//        }
//    }
//    class ConstructorParameter
//    {
//        static void Main(string[] args)
//        {
//            My my = new My("김세훈", 37);
//            my.PrintMy();
//        }
//    }
//}




// 매개 변수가 있는 생성자로 원의 넓이를 구하는 프로그램 만들기

//public class Circle
//{
//    private int _radius;
//    public Circle(int radius)
//    {
//        _radius = radius;
//    }
//    public double GetArea()
//    {
//        return Math.PI * _radius * _radius;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Circle circle = new Circle(3);
//        Console.WriteLine(circle.GetArea());
//    }
//}


// 클래스에 생성자 여러개 만들기(생성자 오버로드 Constructor overlaod)

// 클래스에는 매개변수를 달리해서 생성자를 여러개 만들수있다.
// 이러한 기능을 생성자 오버로드 라고한다. 

//class ConstructorLog
//{
//    public ConstructorLog()
//    {
//        Console.WriteLine("기본생성자 실행");
//    }
//    public ConstructorLog(string msg)
//    {
//        Console.WriteLine("오버로드된 생성자 실행: " + msg);
//    }
//}
//class ConstructorOverload
//{
//    static void Main(string[] args)
//    {
//        ConstructorLog cl = new ConstructorLog();
//        ConstructorLog cl1 = new ConstructorLog("C#");
//        ConstructorLog cl2 = new ConstructorLog("ASP.NET");
//    }
//}

// 메서드와 마찬가지로 매개변수를 달리해서 클래스 하나에 생성자 여러개를 만들수 있다. 

// 필드 생성자 메서드를 함께 사용해보기

//class Person
//{
//    private string _name;
//    public Person()
//    {
//        _name = "김세훈";
//    }
//    public Person(string n)
//    {
//        _name = n;
//    }
//    public string GetName()
//    {
//        return _name;
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Person ps = new Person();
//        ps.GetName();
//        Person ps1 = new Person("세훈");
//        ps1.GetName();

//        Console.WriteLine(ps.GetName()+ " "+ ps1.GetName());
//    }
//}

// 생성자도 정적생성자가 있음

//namespace ConstructorAll
//{
//    public class Person
//    {
//        private static readonly string _name; // 
//        private int _age;
//        static Person(){_name = "김세훈";} // static 생성자는 인스턴스 없이 쓰지만 매개변수를 가질 수 없다.
//        public Person(){_age = 21;}
//        public Person(int age)
//        {
//            _age = age;
//        }
//        public static void Show()
//        {
//            Console.Write($"이름: {_name}");
//        }
//        public void Print()
//        {
//            Console.WriteLine($"나이: {_age}");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Person.Show();
//            new Person().Print();
//            new Person(22).Print();
//        }
//    }
//}

//This() 생성자로 다른 생성자 호출하기
// 생성자에서 This()는 자신의 또다른 생성자를 의미한다.
// this() 생성자로 매개변수가 있는 생성자에서 매개변수가 없는 생성자를 호출하거나 또 다른 생성자들을 호출 할 수 있다.

//class Say
//{
//    private string _message = "[1] 안녕";
//    public Say()
//    {
//        Console.WriteLine(this._message);
//    }
//    public Say(string message) : this() // this 생성자로 자신의 매개변수가 없는 생성자를 먼저 호출
//    {
//        this._message = message; // 매개변수가 있는 생성자 자체도 호출
//        Console.WriteLine(this._message); 
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        new Say("[2] 잘가");
//    }
//}


// 생성자 포워딩
// this() 생성자를 사용하면 생성자를 포워딩 할 수 있으므로 다른 생성자에 값을 전달하기 좋다.

//class Money
//{
//    public Money() : this(1000) { }
//    public Money(int money)
//    {
//        Console.WriteLine(money);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        var basic = new Money();       
//        var bonus = new Money(2000);
//    }
//}



