

class Program
{
    static List<List<int>> NewArr; // 리스트를 자료형으로 사용하는 리스트
    static List<int>[] ArrList; // 
    static int[][] Arr2DInt;
    static void Main(string[] args)
    {
        NewArr = new List<List<int>>(); // 리스트 안에 리스트를 담음 내가 리스튼데 내 인자가 리스트임
        ArrList = new List<int>[10]; // 1차원배열인데 리스트를 자료형으로 사용하는 배열. 위와의 차이는 배열의 크기를 정해줘야 한다는것
        Arr2DInt = new int[10][];// int 배열을 담을수 있는 배열 


        //2차원 배열의 사용법은
        Arr2DInt[0] = new int[100];
        Arr2DInt[1] = new int[30];

        //크기가 고정되어있으면 배열을 쓰고, 크기가 중간에 증가해야하면 리스트를 쓴다.
    }
}