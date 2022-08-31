// 네임스페이스는 프로그램 규모가 커질때 클래스 이름이 충돌하는것을 방지한다.
// 클래스를 모아서 관리하는 개념
// 닷넷에는 수많은 클래스가 있다. 이러한 클래스들은 의미가 같은 클래스끼리 네임스페이스로 묶어 관리한다.
// console 클래스처럼 주요 클래스들은 System 에 선언되어있다.

//특징
// 서로 관련이있는 클래스, 구조체, 열거형 등의 형식과 또다른 네임스페이스 등을 묶어 관리해줌
// 클래스 이름이 중복되는 것을 방지
// 클래스를 계층형으로 묶어 관리
// 패키지라는 단어와 비슷

// 네임스페이스 만들기

namespace Sehun
{
    namespace MyCar { }
    namespace YourCar { }
    
    class Car
    {

    }
}
namespace Foo
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("[1] Foo 네임스페이스의 Car 클래스 호출");
        }
    }
}

namespace Bar
{
    public class Car
    {
        public void Go()
        {
            Console.WriteLine("[2] Bar 네임스페이스의 Car 클래스 호출");
        }
    }
    
}

class NameSpaceNote
{
    static void Main(string[] args)
    {
        Foo.Car foocar = new Foo.Car();
        foocar.Go();
        Bar.Car bar = new Bar.Car();
        bar.Go();
    }
}
