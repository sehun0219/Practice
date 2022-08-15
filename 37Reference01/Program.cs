class Player
{
    public int HP = 100;
    public int AT = 10;
    public void TestFunc(Player _Player)
    {
        TestFuncPart1(_Player);
    }
    public void TestFuncPart1(Player _Player)
    {
        TestFuncPart2(_Player);
    }
    public void TestFuncPart2(Player _Player)
    {
        _Player.AT = 20;
    }
}


class Program
{
    static void ArrTest(int[] _ArrTest)
    {
        _ArrTest[0] = 99999;
    }
    static void ClassTest(Player _Test)
    {
        _Test.AT = 10000;
    }

    
    static void Main(string[] args)
    {

        Player NewPlayer = new Player();
        NewPlayer.AT = 50;
        

    }
}

