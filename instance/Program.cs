class SharedAndInstance
{
    public void InstanceMember() => Console.WriteLine("[2] Instance Member");
    public static void StaticMember() => Console.WriteLine("[1] Static Member");

    static void Main(string[] args)
    {
        SharedAndInstance.StaticMember();
        SharedAndInstance sharedAndInstance = new SharedAndInstance();
        sharedAndInstance.InstanceMember();
    }
    
    
}