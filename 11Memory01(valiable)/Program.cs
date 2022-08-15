class Player
{
    public int Test(int _dmg)
    {
        _dmg = 1000;
        return _dmg;
    }
}
class Program
{
    static void Main(string[] args)
    {
        
        Player player = new Player();
        //함수의 인자값
        int value = 0;
        player.Test(value);
        Console.WriteLine(value); // 값이 0이나옴 왜 1000이 안나올까?
        // 값과 위치에 대한 이해를 해야함
        // 지역변수에서 벌어지는 일은 그 함수 안에서일일 뿐임
        // 밖에 메인에 있는 변수에는 전혀 영향을 줄수도 받을수도 없다.

        // 바꾸려면 리턴값을 만들어서 벨류가 그값을 받게 만듬
        value = player.Test(value);
        Console.WriteLine(value);
    
        
    }
}