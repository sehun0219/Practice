using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class TetrisGameScreen
{
    protected List<List<string>> BlockList = new List<List<string>>(); // List는 list를 list하는 제네릭 클래스

    public int X {get{return BlockList[0].Count; }}
    public int Y { get { return BlockList.Count; } }
    public TetrisGameScreen(int _X, int _Y, bool TopAndBotLine) //TetrisGameScreen 을 정의해줍니다.
    {
        for (int y = 0; y < _Y; y++) // X축과 Y축을 정의합니다. 
        {
            BlockList.Add(new List<string>()); // 리스트에 새로운 리스트를 추가한다는 의미는
                                               // _Y개짜리 배열 첫칸에 앞으로 만들 리스트를 넣겠다는 말임 
            for (int x = 0; x < _X; x++)
            {
                BlockList[y].Add("□");
            }
        }
        if (TopAndBotLine == false)
        {
            return;
        }

        for (int i = 0; i < BlockList[0].Count; i++)
        {
            BlockList[0][i] = "▣";
        }
        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
        {
            BlockList[BlockList.Count - 1][i] = "▣";
        }
    }

    public void SetBlock(int _y, int _x, string _Type)
    {
        BlockList[_y][_x] = _Type;
    }
    public bool IsBlock(int _y, int _x, string _Type)
    {
        return BlockList[_y][_x] == _Type;
    }
    public void Clear() 
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                if (y == 0 || y == BlockList.Count-1)
                {
                    BlockList[y][x] = "▣";
                    continue;
                }
                BlockList[y][x] = "□";

            }
        }
    }
    public virtual void Render() // 화면에 띄우는 함수
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                Console.Write(BlockList[y][x]);
            }
            Console.WriteLine();
        }
    }
    
}