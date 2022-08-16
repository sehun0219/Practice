using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//BT_I, // STICK
//BT_T, // T SHAPE
//BT_L, // RIGHT
//BT_J, // LEFT
//BT_O, // SQUAR 
//BT_Z, // Z SHAPE 
//BT_S, // S SHAPE


//BD_T // Diraction Top
//BD_R // Diraction Right
//BD_B // Diraction Bottom
//BD_L // Diraction Left


//7개 넣기위한 첫번째 리스트 그리고 4개 넣기위한 리스트 그리고 그 4개는 2차원배열
// List<List<string[][]>> AllBlockData = new
// AllBlockData[BT_I][BD_R];




partial class Block
{
    List<List<string[][]>> AllBlock = new List<List<string[][]>>();
    void DataInit()
    {
        for (int BT = 0; BT < (int)BLOCKTYPE.BT_MAX; ++BT)
        {
            AllBlock.Add(new List<string[][]>());
            for (int BD = 0; BD < (int)BDIR.MAX; ++BD)
            {
                AllBlock[BT].Add(null); 
            }
        }

        #region I
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BDIR.T] = new string[][]
        {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_I][(int) BDIR.R] = new string[][]
        {
        new string[] { "■", "■", "■", "■" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_I][(int) BDIR.B] = new string[][]
        {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_I][(int) BDIR.L] = new string[][]
        {
        new string[] { "■", "■", "■", "■" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region T
        AllBlock[(int) BLOCKTYPE.BT_T][(int) BDIR.T] = new string[][]
        {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_T][(int) BDIR.R] = new string[][]
        {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_T][(int) BDIR.B] = new string[][]
        {
        new string[] { "□", "□", "□", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_T][(int) BDIR.L] = new string[][]
        {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region J
        AllBlock[(int) BLOCKTYPE.BT_J][(int) BDIR.T] = new string[][]
        {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_J][(int) BDIR.R] = new string[][]
        {
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_J][(int) BDIR.B] = new string[][]
        {
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_J][(int) BDIR.L] = new string[][]
        {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region L
        AllBlock[(int) BLOCKTYPE.BT_L][(int) BDIR.T] = new string[][]
        {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_L][(int) BDIR.R] = new string[][]
        {
        new string[] { "□", "□", "■", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_L][(int) BDIR.B] = new string[][]
        {
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_L][(int) BDIR.L] = new string[][]
        {
        new string[] { "■", "■", "■", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region Z
        AllBlock[(int) BLOCKTYPE.BT_Z][(int) BDIR.T] = new string[][]
        {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_Z][(int) BDIR.R] = new string[][]
        {
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_Z][(int) BDIR.B] = new string[][]
        {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_Z][(int) BDIR.L] = new string[][]
        {
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region S
        AllBlock[(int) BLOCKTYPE.BT_S][(int) BDIR.T] = new string[][]
        {
        new string[] { "□", "■", "■", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_S][(int) BDIR.R] = new string[][]
        {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        }; 
        AllBlock[(int) BLOCKTYPE.BT_S][(int) BDIR.B] = new string[][]
        {
        new string[] { "□", "■", "■", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        }; 
        AllBlock[(int) BLOCKTYPE.BT_S][(int) BDIR.L] = new string[][]
        {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        #endregion
        #region O
        AllBlock[(int) BLOCKTYPE.BT_O][(int) BDIR.T] = new string[][]
        {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_O][(int) BDIR.R] = new string[][]
        {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_O][(int) BDIR.B] = new string[][]
        {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        AllBlock[(int) BLOCKTYPE.BT_O][(int) BDIR.L] = new string[][]
        {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };
        #endregion


    }
}
