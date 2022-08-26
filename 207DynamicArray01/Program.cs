
//arr 배열에 {1, 2, 3, 4}, { 5, 6, 7}, { 8, 9}
//배열을 초기화 한 후 각 값을 2씩 증가시키는 프로그램을 만드시오.

//여기서 arrPrint()함수로 배열을 출력하고 addOneArr()함수로 값을 증가시키고

//addTwoArr()함수로 addOneArr()함수를 호출하시오.

//(단, addTwoArr() 함수에는 매개변수로 이차원 배열과 증가시킬 값,

//addOneArr() 함수에는 매개변수로 일차원 배열과 증가시킬 값을 받는다.)

class Program
{
    static void Main(string[] args)
    {
        int[][] arr = new int[][] 
        {
            new int[] {1,2,3,4},
            new int[] {5,6,7},
            new int[] {8,9}
        };
        
        

        arrPrint(arr);
        addArr(arr, 2);
        Console.WriteLine("---------");
        arrPrint(arr);
    }
    static void arrPrint(int [][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr[i].Length; j++)
            {
                Console.Write(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    static void addArr(int[][] Array, int PlusValue)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            for (int j = 0; j < Array[i].Length; j++)
            {
                Array[i][j] = Array[i][j] + PlusValue;
            }
           
        }
    }
    
}