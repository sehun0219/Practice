
// 종료자, 소멸자, 가비지 수집기 라고불림
// 클래스의 인스턴스를 사용한 후 최종 정리할 때 실행되는 클래스에서 가장 늦게 호출하는 메서드다.

// C#은 닷넷 가비지 수집기가 개체가 소멸할때 메모리를 해제해줌
// 호텔의 주차요원과 역할이 비슷함


//namespace DestructorDemo
//{
//    public class Car
//    {
//        private string _name;
//        public string GetName()
//        {
//            return _name;
//        }
//        public Car()
//        {
//            _name = "승용차";
//        }
//        public Car(string name)
//        {
//            this._name = name;
//        }
//        ~Car()
//        {
//            Console.WriteLine("폐차" + _name);
//        }
//    }
//    class MyClass
//    {
//        static void Main(string[] args)
//        {
//            Car car1 = new Car();
//            Console.WriteLine(car1.GetName());
//            Car car2 = new Car("캠핑카");
//            Console.WriteLine(car2.GetName());
//        }
//    }
//}

