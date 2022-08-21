using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum BLOCKTYPE
{
    BT_I, // STICK
    BT_L, // RIGHT
    BT_J, // LEFT
    BT_O, // SQUAR 
    BT_Z, // Z SHAPE 
    BT_S, // S SHAPE
    BT_T, // T SHAPE
    BT_MAX,

}

enum BDIR
{
    L,
    T,
    R,
    B,
    MAX
}


partial class Block // 블록은 일곱종류.. 가장 긴 일자 블록은 4칸.. 
{
    int X = 0;
    int Y = 0;
    string[][] Arr = null;
    string BlockType = "■";


    List<List<string>> BlockData = new List<List<string>>(); // 테트리스 블록을 구현하는 리스트 X 리스트 (4 X 4) 데이터 구조
    
    
    BLOCKTYPE CurBlockType = BLOCKTYPE.BT_T;
    BDIR CurDirType = BDIR.T;


    Random NewRandom = new Random();
    TetrisGameScreen Screen = null;
    AccScreen AccScreen = null;
    
    
    public Block(TetrisGameScreen _Screen, AccScreen _AccScreen)
    {
        if (null == _Screen || null == _AccScreen)
        {
            return;
        }
        Screen = _Screen;
        AccScreen = _AccScreen;
        DataInit();
        Reset();
    } 








    public void RandomBlockType()
    {
        int RandomIndex = NewRandom.Next((int) BLOCKTYPE.BT_I, (int) BLOCKTYPE.BT_MAX);
        //int RandomIndex = (int) BLOCKTYPE.BT_I;
        CurBlockType = (BLOCKTYPE)RandomIndex;
    }
    private void SettingBlock(BLOCKTYPE _Type, BDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
    }

    public void SetAccScreen()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                // 내가 "■"일때 체크
                if ("■" == Arr[y][x])
                {
                    AccScreen.SetBlock(Y + y - 1, X + x, Arr[y][x]);
                }
            }
        }
    }
    public bool DownCheck() // 내가 더이상 내려갈수 없는 경우
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                // 내가 "■"일때 체크
                if ("■" == Arr[y][x])
                {
                    //내가 Acc스크린의 Y랑 똑같으면 나는 못내려감
                    if (AccScreen.Y == Y + y || true == AccScreen.IsBlock( Y + y, X + x, Arr[y][x]))
                    {
                        //쌓인다.
                        SetAccScreen();
                        //새블록이 위에서 새로떠러저야함
                        Reset();
                        return true; 
                    }
                }
            }
        }
        return false;
    }
    public void Down()
    {
        // 더이상아래 내려갈수없으면 쌓인다.
        if (true== DownCheck())
        {
            return;
        }
        Y += 1;
        // AccScreen에만 그리고 나를 위로 올려보내고 새로운 나로 바뀌어야함.

    }
    private void Input()
    {
        if (false == Console.KeyAvailable) // 내가 키를 입력하면 인풋이 실행돼라
        {
            return;
        }
        
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.Q:
                //왼쪽돌리기
                --CurDirType;
                if (0 > CurDirType)
                {
                    CurDirType = BDIR.L;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.E:
                //오른쪽으로 돌리기
                ++CurDirType;
                if (BDIR.MAX == CurDirType)
                {
                    CurDirType = BDIR.T;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.S:
                Down();
                
                break;
            case ConsoleKey.Spacebar:
                break;
        }
    }
    public void Move()
    {
        Input();
        for (int y = 0; y < 4; ++y)
        {
            for (int x = 0; x < 4; ++x)
            {
                if (Arr[y][x] == "□")
                {
                    continue;
                }
                Screen.SetBlock(Y + y, X+x, Arr[y][x]); // 그린다. // 더하는이유는 시간지나면서 내려가니까
            }
        }
    }

    public void Reset()
    {
        RandomBlockType();
        X = 0;
        Y = 1;
        SettingBlock(CurBlockType, CurDirType);
    }

}