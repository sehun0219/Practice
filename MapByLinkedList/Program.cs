

// 캐릭터는 태초마을에서 태어나 초보사냥터와 중급사냥터로 이동할수 있다.
// 초보사냥터에서는 중급마을과 태초마을로 이동할 수 있다. 
// 중급사냥터에서는 중급마을로 이동할 수 있다.
// 중급마을에서는 고급사냥터로 이동할 수 있다. 

class Zone
{
    public string Name = "None";
    public List<Zone> LinkZone = new List<Zone>();
    // 자기자신을 레퍼런스로해서 계속 연결하는 모양
    public Zone(string _name)
    {
        Name = _name;
    }

    public Zone Update()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("You are in " + Name);
            Console.WriteLine("Where would you want to move into?");
            for (int i = 0; i < LinkZone.Count; i++)
            {
                Console.WriteLine((i+1).ToString() + ". " + LinkZone[i].Name);
            }
            //ConsoleKey.D1 = 49
            int number = (int) Console.ReadKey().Key;

            number -= 49;
            return LinkZone[number];
        }
    }
    
}

class Program
{
    static void Main(string[] args)
    {
        Zone newZone0 = new Zone("Beginner village");
        Zone newZone1 = new Zone("Beginner hunting ground");
        Zone newZone2 = new Zone("Intermediate hunting ground");
        Zone newZone3 = new Zone("Intermediate village");
        Zone newZone4 = new Zone("High level hunting ground");

        newZone0.LinkZone.Add(newZone1);
        newZone0.LinkZone.Add(newZone2);

        newZone1.LinkZone.Add(newZone3);
        newZone1.LinkZone.Add(newZone2);

        newZone2.LinkZone.Add(newZone3);

        newZone3.LinkZone.Add(newZone4);

        Zone StartZone = newZone0;

        while (true)
        {
            StartZone = StartZone.Update();
        }
        
    }
}