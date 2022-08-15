
// 대문자로 변경하는 단축키 : Ctrl + Shift + U
struct StructData
{
    // 클래스와 비슷한데 안되는게 있다.
    // = 0 이런게 안됨
    // int a = 0; 리터럴 초기화가 안된다.
    // int b = 0;
    // = 0 이 기본이라 안됨

    public int a;
    public int b;

    public void Func()
    {
        a= 10;
        b= 10;
    }
}

class Program
{
    static void Test(StructData _data)
    {
        _data.a= 10000;
    }
    // 위와 아래는 같음 == 이걸 설명할 수 있을 때 까지 계속 생각해야함
    static void Test(int _data)
    {
        _data = 10000;
    }


    static void Main(string[] args)
    {
        StructData NewStructData = new StructData(); // struct도 클래스처럼 객체화 가능
        NewStructData.a = 10; //이렇게 초기화 해줘도 됨
        NewStructData.b = 10;

        // 참조형과 값형이 있다.
        // 클래스를 객체화하면 참조형임 (어딘가에 메모리가 있고 그걸 가르키는 존재)
        // 클래스 처럼 생겼고 비슷하게 이용하지만 값형인 애가 struct임
        // 확인하는 방법은 아래처럼 함수에 넣었다가 빼서 값이 변하면 참조형
        // 안변하면 값형임
        Test(NewStructData);
    }
}