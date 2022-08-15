

class Player
{
    private int mAT;
    public int AT { get { return mAT; } set { mAT = value; } }

}



class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(); // 레퍼런스형 자료는 힙에 본체를 만들어 놓고 스텍에서 매인함수를 통해 참조해서 씀
        Player player1 = null; // player1 Player를 참조하지만 값은 비워놓겠다는 의미
        Console.WriteLine(player.AT);
        Console.WriteLine(player1.AT); // NullReferenceException

    }
}