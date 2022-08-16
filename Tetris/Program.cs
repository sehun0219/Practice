// 테트리스 블록들이 움직일 수 있는 배경을 만듬
// 커서가 움직이는 한칸을 하나의 셀로 생각하고 그 커서들이 출력하는 모양을 이용해서 블록을만들어줌
// 블록을 배경위에 덮어쓰고, 커서를 움직였을때 입력값이 바뀌게 만듬


class Program
{
    static void Main(string[] args)
    {
        TetrisGameScreen NewTGS = new TetrisGameScreen(10, 15, true);
        AccScreen NewASC = new AccScreen(NewTGS);
        Block NewBlock = new Block(NewTGS,NewASC);


        while (true)
        {
            for (int i = 0; i < 40000000; i++)
            {
                int a = 0;
            }

            Console.Clear();
            NewTGS.Render();
            //쌓이는것에 대한 코딩이 필요함
            //블록이 맨 아래 쌓이면 
            NewTGS.Clear();
            NewASC.Render();
            NewASC.DestroyCheck();
            NewBlock.Move();
        }
        
        
    }
}