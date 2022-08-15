//언어를 아는것의 의미는 
// 붉은줄이 왜가는지 설명가능하면 아는것임


// 프로그래밍에 있어서 기본기라고 생각하는것 3가지


// 1. 문자열
// 2. 디버깅 (중단점)(기본기중 95%)
// 3. 파일입출력 ( 저장하고 읽어오고 )


class Program
{
    static void Main(string[] args)
    {
        char [] chars = {'a', 'b', 'c', 'd', 'e'};
        string strings = "abc";
        int aaa = 1000; // 얘도 구조체이다. 
        int AAA = new int(); 
        AAA.CompareTo(aaa);
        strings = aaa.ToString();
        Console.WriteLine(strings);

        // int는 구조체고 내부의 맴버변수나 함수가 존재하고 그것을 통해서 문자열로 변환을 해줄 수 있다.

        string Left = "Hi";
        string Right = "everyone";
        string result = Left + Right;
        Console.WriteLine(result + strings);
    }
}