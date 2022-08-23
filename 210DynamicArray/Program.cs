
Console.WriteLine("몇 개의 숫자를 입력 하시겠습니까?");
int input = int.Parse(Console.ReadLine());
Console.WriteLine( "배열에 들어갈 숫자를 입력하세요.");

int[] arr = new int[input];  
int count = 0;
for (int i = 0; i < input; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
    count++;
}








