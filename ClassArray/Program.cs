public class CategoryClass
{
    public void Print(int i)
    {
        Console.WriteLine(i);
    }
    
    class ClassArray
    {
        static void Main(string[] args)
        {
            CategoryClass[] categoryClasses = new CategoryClass[3]; // 클래스도 배열로 선언할 수 있다.
            categoryClasses[0] = new CategoryClass(); // 인스턴스로 배열 값을 설정할 수 있다.
            categoryClasses[1] = new CategoryClass();
            categoryClasses[2] = new CategoryClass();
            for (int i = 0; i < categoryClasses.Length; i++)
            {
                categoryClasses[i].Print(i);
            }
        }
    }
}