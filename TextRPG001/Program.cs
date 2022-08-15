




class FightUnit
{
    protected string name = "None";
    protected int AT = 10;
    protected int HP = 50;
    protected int MaxHP = 100;

    public bool IsDeath()
    {
        return HP <= 0;
    }

    public void SetName(string _name)
    {
        name = _name;
    }

    public void PrintHP()
    {
        Console.WriteLine("");
        Console.Write("Your HP is Max");
        Console.ReadLine();
    }
    public void GetMaxHP()
    {
        if (HP >= MaxHP)
        {
            Console.WriteLine("");
            Console.WriteLine("you are already full");
            Console.ReadKey();
        }
        else
        {
            this.HP = MaxHP;
            PrintHP();
        }
    }
    public void StatusRender()
    {
        Console.WriteLine(name);
        Console.WriteLine("==========================");
        Console.WriteLine("\t Attack : " + AT);
        Console.Write("\t HP : ");
        Console.Write(HP);
        Console.Write("/");
        Console.WriteLine(MaxHP);
        Console.WriteLine("==========================");
    }

   public void Damage(FightUnit _OtherUnit)
    {
        Console.Write(name);
        Console.Write(" gets damgae  :  ");
        Console.Write(_OtherUnit.AT);
        Console.Write(" ");
        Console.ReadKey();
        HP -= _OtherUnit.AT;

    }
    
}
class Player : FightUnit
{
    private Inven PlayerInven = new Inven(5, 3);
    public Inven PInven { get { return PlayerInven; } }
    public void PrintHP()
    {
        Console.WriteLine("");
        Console.Write("Your HP is : ");
        Console.WriteLine(HP);
        Console.ReadLine();
    }
    public void GetMaxHP()
    {
        if (HP >= MaxHP)
        {
            Console.WriteLine("");
            Console.WriteLine("** You are already full! **");
            Console.ReadKey();
        }
        else
        {
            this.HP = MaxHP;
            Console.WriteLine("** Now, your HP is full! **");
        }
    }
    public void InChent()
    {
        Console.WriteLine("** All of ur equipmet is inchented!! **");
    }
    public Player()
    {
        name = "Player";
    }
}

class Monster : FightUnit
{
    public Monster(string _Name)
    {
        name = _Name;
    }
}



enum STARTSELECT
{
    SelectTown,
    SelectHunt,
    NonSelect
}

namespace TextRPG
{
    class Program
    {
        static STARTSELECT StartSelect()
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine("Where you wanna go?");
            Console.WriteLine("1. Town");
            Console.WriteLine("2. Hunt");
            Console.Write("Your decision is : ");
            ConsoleKeyInfo CKL = Console.ReadKey();

            switch (CKL.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("");
                    Console.WriteLine("==========================");
                    Console.WriteLine("");
                    Console.WriteLine("You are heading to Town");
                    Console.ReadKey();
                    return STARTSELECT.SelectTown;
                case ConsoleKey.D2:
                    Console.WriteLine("");
                    Console.WriteLine("==========================");
                    Console.WriteLine("");
                    Console.WriteLine("You are heading to Hunt");
                    Console.ReadKey();
                    return STARTSELECT.SelectHunt;
                default:
                    Console.WriteLine("");
                    Console.WriteLine("==========================");
                    Console.WriteLine("");
                    Console.WriteLine("Enter the option correctly");
                    Console.ReadKey();
                    return STARTSELECT.NonSelect;
            }
        }

        static void Shop(Player _Player, Inven _ShopInven)
        {
            while (true)
            {
                Console.Clear();
                _ShopInven.Render();
                _Player.PInven.Render();
                Console.ReadKey();
            }
        }


        static void Town(Player _player)
        {
            Inven ShopInven = new Inven(5, 3);
            ShopInven.AddItem(new Item("존야",500));
            ShopInven.AddItem(new Item("팬댄", 800));
            ShopInven.AddItem(new Item("보이드", 500));
            ShopInven.AddItem(new Item("데켑", 500));

            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                Console.WriteLine("==========================");
                Console.WriteLine("What would you want to do in Town?");
                Console.WriteLine("1. HP를 회복한다.");
                Console.WriteLine("2. 상점으로 간다.");
                Console.WriteLine("3. Get out of town");
                ConsoleKeyInfo CKL = Console.ReadKey();
                switch (CKL.Key)
                {
                    case ConsoleKey.D1:
                        _player.GetMaxHP();
                        _player.PrintHP();
                        
                        break;
                    case ConsoleKey.D2:
                        Shop(_player, ShopInven);
                        
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("");
                        Console.WriteLine("==========================");
                        Console.WriteLine("");
                        Console.WriteLine("You are heading to Town");
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void Hunt(Player _player, Monster _monster)
        {
            while (true)
            {
                Console.Clear();
                _player.StatusRender();
                _monster.StatusRender();

                while (false == _monster.IsDeath() && false == _player.IsDeath())
                {
                    Console.Clear();
                    _player.StatusRender();
                    _monster.StatusRender();
                    _monster.Damage(_player);

                    if (_monster.IsDeath() == false)
                    {
                        _player.Damage(_monster);
                    }
                }
                Console.WriteLine("Battle is over");
                Console.ReadKey();
            }

        }

     

        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster("Oak");
           
            while (true)
            {
                STARTSELECT sTARTSELECT = StartSelect();
                switch (sTARTSELECT)
                {
                    case STARTSELECT.SelectTown:
                        Town(NewPlayer);
                        break;
                    case STARTSELECT.SelectHunt:
                        Hunt(NewPlayer, NewMonster);
                        break;
                    case STARTSELECT.NonSelect:
                        break;
                    default:
                        break;
                }

            }
            
        }
    }
}





