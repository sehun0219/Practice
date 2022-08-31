
// C#에서는 모든 메서드를 클래스 내에서 선언한다.
// 메서드는 클래스가 수행할 기능들을 이름으로 묶어 관리한다.
// 메서드는 개체가 수행할 수 있는 기능, 동작, 행위등을 의미한다.
// 동사 플러스 명사 형태로 네이밍한다.

//class Dog
//{
//    public void Eat()
//    {
//        Console.WriteLine("[1] 밥을 먹는다.");
//        this.Digest();
//    }
//    private void Digest()
//    {
//        Console.WriteLine("[2] 소화를 시킨다.");
//    }
//}
//class MyClass
//{
//    static void Main(string[] args)
//    {
//        Dog dog = new Dog();
//        dog.Eat();
//    }
//}

//  메서드의 매개변수 전달방식 정리

// 메서드의 매개변수 전달 방식은 네가지로 부류된다.

// 1. 값을 직접 전달하는방식
// 2. ref를 사용해서 참조 전달방식
// 3. out 키워드를 사용해서 반환 전달방식
// 4. params 키워드를 사용하는 가변형 전달방식이 있다.

// 1.값 전달방식
// 말 그대로 값을 그대로 복사해서 전달하는 방식을 의미함. 

// 2. 참조전달방식(ref)
// 실제 데이터는 매개변수가 선언된 쪽에서만 저장하고 호출된 메서드에서는 참조만 하는 형태로 변수 이름만 전달하는 방식

// 3. 반환형전달방식(out)
// 메서드를 호출하는 쪽에서 선언만하고 초기화 하지 않고 전달하면 메서드 쪽에서 해당 데이터를 초기화 해서 넘겨주는 방식

// 4. 가변형 전달방식(params)
// 1개 이상의 매개변수를 가변적으로 받을 때 매개변수를 선언하면 params 키워드를 붙인다. 같은 타입으로 하나 이상을 받을 수 있도록
// 배열형으로 받는다.
// 가변길이 매개변수는 반드시 매개변수를 선언할 때 마지막에 위치해야한다.

// 참조전달방식 ref

/*class ParameterRef
{
    static void Do(ref int num)
    {
        num = 20;
        Console.WriteLine("[2]" + num);// Main의 num을 참조하기 전에 Do 메서드에서 값이 변경되면
                                             // 그 변경된 값을 가져옴
    }
    static void Main(string[] args)
    {
        int num = 10;
        Console.WriteLine("[1]"+ num);  // 지역변수 num 10값을 출력
        Do(ref num);
        Console.WriteLine("[3]"+num); // Do 메서드에서 num이 변경되었으므로 그 값을 가져와 20을 출력함
    }
}*/

//매서드를 호출하기전에 지역변수를 초기화하지 않고 호출한 메서드에서 전달한 값을 받아 사용해야할 때가 있다.
// out 의 사용

//class ParameterOut
//{
//    static void Do(out int num)
//    {
//        num = 1234; // ref 처럼 호출한 부분에 적용 반드시 초기화해야함
//        Console.WriteLine("[1]" + num);
//    }
//    static void Main()
//    {
//        int num; // 변수를 반드시 초기화할 필요는 없음
//        Do(out num);
//        Console.WriteLine("[2]" + num);
//    }
//}
// 이처럼 변수를 초기화 하지 않고 특정 메서드에서 초기화 하는 형태도 있다. 이때는 ref / out 키워드를 사용한다.
// Do 메서드에서 초기화해도 Main에서 변수가 같은 값으로 초기화 된다.

// 날짜 형태의 문자열을 날짜형으로 변환

//class DateTimeTryParse
//{
//    static void Main()
//    {
//        DateTime dt; // 반환형 매개변수에 사용될 지역변수(초기화하지 않음)

//        if (DateTime.TryParse("2020-01-01",out dt)) // 변환이 가능하면  dt에 저장
//        {
//            Console.WriteLine(dt);
//        }
//        else
//        {
//            Console.WriteLine("날짜형식으로 변환할 수 없습니다.");
//        }

//        if (DateTime.TryParse("2020-02-02", out var date))
//        {
//            Console.WriteLine(date);
//        }
//    }
//}

// 가변길이 매개변수
// 메서드의 매개변수를 받을 때 배열 형식의 매개변수를 하나 사용해서 가변적으로 하나 이상의 값을 받아 배열에 저장할 
// 수 있는 가변형 매개변수를 제공한다.

// 가변형 매개변수는 params 키워드로 선언한다. 메서드 오버로드와 달리 하나의 매개변수로 하나 이상의 값을 받을 수 있는 구조

class ParamsDemo
{
    static int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
    static int Add(int a, int b = 1)
    {
        return a + b;
    }
    static int Sum(int first = 10, int second = 20)
    {
        return first + second;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(SumAll(3, 5));
        Console.WriteLine(SumAll(3, 5,7));
        Console.WriteLine(SumAll(3, 5,7,9));

        Console.WriteLine(Add(5));
        Console.WriteLine(Add(5,3)); // b의 기본값은 1인데 3이 입력되면 3으로 처리됨


        Console.WriteLine(Sum(5,3));
    }
}
