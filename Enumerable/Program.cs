// 제네릭
// 특정 형식을 지정하여 컬렉션에 저장하고 사용할수 있다. 

// 제네릭 컬렉션은 다른 데이터 형식을 추가할 수 없도록 형식 안정석ㅇ을 적용한다.


// stack  제네릭 클래스
// 일반 스택 클래스랑 제네릭 클래스의 차이점
// object에서 출력하고 싶은 형식으로 형식변환 해야 됨
// 박싱과 언박싱 작업을 하지 않아 성능이 향상된다.
// 오브젝트는 참조형이고 int는 값형임

// List<T> 제네릭 클래스 사용하기
// List<int> 정수형의 리스트를 나타내고 List<string>은 문자열 리스트를 나타냄


// 배열과 List<T> 제네릭 리스트

// Enumerable class
// System.Linq 네임스페이스에 들어있는 클래스
// Range(), Repeat() 메서드를 제공함
// 특정범위의 정수 컬렉션을 쉽게 만듬
//var num = Enumerable.Range(1, 10);
//var num2 = Enumerable.Repeat(5, 3);
//var num3 = Enumerable.Range(1, 100).Where(i => i % 2 == 0).Reverse().Skip(10).Take(5);

//foreach (var item in num3)
//{
//    Console.WriteLine(item);
//}


    //Dictionary<T,T> 
    // key and value로 값을 저장



    using System.Collections.Generic;

class MyClass
{
    static void Main(string[] args)
    {
        Dictionary<string, string> map = new Dictionary<string, string>();
        map.Add("플라워", "Endless");
        map.Add("야다", "이미슬픈사랑");
        map.Remove("야다");
        map["얀"] = "그래서그대는";

        foreach (KeyValuePair<string, string> item in map)
        {
            Console.WriteLine(item.Key, item.Value);
        }

        foreach (var item in map)
        {
            Console.WriteLine("{0}은 {1}의 노래제목입니다.", item.Value, item.Key);
        }



        try
        {
            map.Add("플라워", "에피소드1");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

            
        
    }
}