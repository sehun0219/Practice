class TryCatchFinallyDemo
{
    static void Main(string[] args)
    {
        int a = 3;
        int b = 0;
        try
        {
            a = a / b;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("try 구문을 정상 종료함");
        }
        try
        {
            throw new Exception("내가만든 에러");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally 
        {
            Console.WriteLine("정상종료");
        }
    }
}