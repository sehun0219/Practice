

// Two dimension Matrix Calculator
// 
//A = 3 2   B = 9 2   [0,0]29 [0,1]20
//    1 4       1 7   [1,0]13 [1,1]30

class Program
{
    static void Main(string[] args)
    {
        int[,] matrixA = new int[,] { { 3, 2 }, { 1, 4 } };
        int[,] matrixB = new int[,] { { 9, 2 }, { 1, 7 } };

        Program program = new Program();
        int[,] matrixAB = program.Multiple(matrixA, matrixB);

        for (int i = 0; i < matrixAB.GetLength(0); i++)
        {
            for (int j = 0; j < matrixAB.GetLength(1); j++)
            {
                Console.Write(matrixAB[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
     }
    public int[,] Multiple(int[,] _matrixA, int[,] _matirxB)
    {
        int[,] result ={{_matrixA[0,0]*_matirxB[0,0] + _matrixA[0,1]*_matirxB[1,0],_matrixA[0,0]*_matirxB[0,1] + _matrixA[0,1]*_matirxB[1,1]},
                        {_matrixA[1,0]*_matirxB[0,0] + _matrixA[1,1]*_matirxB[1,0],_matrixA[1,0]*_matirxB[0,1] + _matrixA[1,1]*_matirxB[1,1]}};
        return result;
    }
}

