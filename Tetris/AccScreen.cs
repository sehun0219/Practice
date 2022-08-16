using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 부모 스크린은 10 x 15
// 자식 스크린은 10 x 13
class AccScreen :  TetrisGameScreen
{
    TetrisGameScreen Parent;
    public AccScreen(TetrisGameScreen _Parent) : base (_Parent.X, _Parent.Y-2, false) // 부모님의 생성자를 호출할 수 있다.
    {
        Parent = _Parent;
    }

    public override void Render() // 화면에 띄우는 함수
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                Parent.SetBlock(y + 1,x,BlockList[y][x]);
            }
            Console.WriteLine();
        }
    }

    public void DestroyCheck()
    {
        for (int y = BlockList.Count -1; y >= 0; --y)
        {
            bool IsDestroy = true;
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                if ("□" == BlockList[y][x])
                {
                    IsDestroy = false;
                }
            }
            if (true == IsDestroy)
            {
                // 내려 앉히는 작업을 해야함
                List<string> NewLine = new List<string>();
                for (int i = 0; i < X; i++)
                {
                    NewLine.Add("□");
                }
                BlockList.Insert(0, NewLine);
                BlockList.RemoveAt(BlockList.Count - 1);
                y = BlockList.Count - 1;
            }
        }
    }
}