// Property


// 말 그대로 클래스의 특징, 성격, 색상, 크기 등을 나타낸다.
// 속성은 괄호가 없는 메서드와 비슷하다.
// 필드중에서 외부에 공개하고자 하는것을 표현할때 쓴다.
// 코드에서는 private 성격이 있는 필드를 public 속성으로 외부에 공개한다.
// 클래스 안에 선언된 필드의 내용을 set하거나 get(참조)할 때 사용한다.
// 속성값을 설정하는 것을 setter 라고 하며 값을 읽어오는 것을 getter라고 한다.

//class Developer
//{
//    public string _name { get; set; }

//}
//class Car
//{
//    private string name;
//    public string Name { get { return name; } set { name = value; } }
//}
//// get 접근자는 return 구분을 사용해서 특정 값 또는 특정 필드 값을 반환한다. 
//// set 접근자는 value 키워드를 사용해서 속성에 지정된 값을 가져오는 역할을 한다.
//// 가저온 value는 계산식에 사용하거나 속성과 관련한 필드에 저장한다.

//class Person // 전체속성 
//{
//    private int age;

//    public int _age
//    {
//        get { return age; }
//        set { age = value; }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        var person = new Person();
//        person._age = 37;
//        Console.WriteLine(person._age);

//        Developer developer = new Developer();
//        developer._name = "김세훈";
//        Console.WriteLine(developer._name);
//    }
//}
// Developer 클래스에는 _name 속성 하나만 정의되어 있다. 
// Developer 클래스의 인스턴스를 생성한 후 _name 속성에 값을 set 하고 이 값을 get 해서 사용할 수 있다.
/*
public class Car
{
    private string name; // 필드 쓰고
    public string Name { get { return name; } set { name = value; } } // 속성 쓰는 형식

    public string Color { get; set; }// 자동구현속성
}

class Program
{
    static void Main(string[] args)
    {
        Car c1 = new Car();
        c1.Name = "비엠";
        Console.WriteLine(c1.Name);

        Car c2 = new Car();
        c2.Name = "벤츠"; c2.Color = "Red";
        Console.WriteLine(c2.Color + c2.Name);
    }
}*/


//namespace PropertyAll
//{
//    public class Car
//    {
//        private string _color; 
//        public Car()
//        {
//            this._color = "black";
//        }
//        public void SetColor(string color)
//        {   
//            this._color = color;
//        }
//        public string GetColor()
//        {
//            return _color;
//        }
//        public string Color { get { return _color; } set { _color = value; } }
//        public string Make { get { return "한국자동차"; } }
//        private string _Type;
//        public string Type { set { _Type = value; } }
//        public string Name { get; set; }
//    }

//    class PropertyAll
//    {
//        static void Main(string[] args)
//        {
//            Car car1 = new Car();
//            car1.SetColor("Red");
//            Console.WriteLine(car1.GetColor());

//            Car whiteCar = new Car();
//            whiteCar.Color = "White";
//            Console.WriteLine(whiteCar.Color);

//            Car k = new Car();
//            Console.WriteLine(k.Make);

//            Car car = new Car();
//            car.Type = "중형";

//            Car myCar = new Car();
//            myCar.Name = "테슬라";
//            Console.WriteLine(myCar.Name);
//        }
//    }
//}


//

public class Customer
{

}