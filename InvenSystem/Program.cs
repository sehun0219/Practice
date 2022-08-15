class Program
{
    static void Main(string[] args)
    {
        // ★★□□□ 
        // □□□□□
        // □□□□□
        Inven NewInven = new Inven(5, 3);
        
        // 데이터를 배열에 넣어야지 이제 (아이템을 인벤에 넣어볼까요)
        // 인벤이 아이템을 가지는 함수를 만들어서 넣어야지
        Item item = new Item("철검", 100);
        NewInven.AddItem(new Item("철검", 100));
        NewInven.AddItem(new Item("갑옷", 100));
        NewInven.AddItem(new Item("포션", 100), 5);

        // NewInven.AddItem(new Item("포션", 100), 17);
        
        // 객체지향 개발 5대 원리
        // 1. 단일 책임의 원칙
        // 2. 개방 폐쇄의 원칙
        // 3. 리스코브치환의 원칙
        // 4. 인터페이스 분리의 원칙 = 함수를 잘개 쪼개서 만들어서 조합해서 새 기능을 만들어라
        // 5. 의존성 역전의 원칙

        
        while (true)
        {
            Console.Clear();
            NewInven.Render();
            ConsoleKeyInfo CheckKey = Console.ReadKey();
            switch (CheckKey.Key)
            {
                case ConsoleKey.LeftArrow:
                    NewInven.selectMoveLeft();
                    break;
                case ConsoleKey.RightArrow:
                    NewInven.selectMoveRight();
                    break;
                case ConsoleKey.UpArrow:
                    NewInven.selectMoveUp();
                    break;
                case ConsoleKey.DownArrow:
                    NewInven.selectMoveDown();
                    break;
            }
        }

    }
}