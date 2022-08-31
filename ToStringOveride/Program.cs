class MyClass
{

}
class Your
{
    public override string ToString()
    {
        return "새로운 반환 문자열";
    }

}
class ToStringMethod
{
    static void Main(string[] args)
    {
        MyClass my = new MyClass();
        Console.WriteLine(my);
        Your my2 = new Your();
        Console.WriteLine(my2);
    }
}