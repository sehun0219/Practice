// 자료구조를 말하면서 그림 없이 하지마라

// 배열형 시퀀스 자료구조형 1번 = 조금 편리한 배열(중간자료수정가능), 클래스형 버전
// 메모리 구조는 배열임

class Item
{
    // 만약에 아이템을 관리하고 싶어서 아이템 클레스를 만들고 리스트 자료구조를 만들어서 
    // 관리하고 싶다면 
    // 메인함수 안에다가 List<Item> ItemList = new List<Item>(); 해놓고 쓰면됨

    // 그런데 아이템 클래스 안에 내가 관리하라고 요청하는게
    // 아이템도 종류가 많으니 매번 바뀌니까 제네릭 클래스여야함
}

class Program
{
    static void Main(string[] args)
    {
        List<int> newList = new List<int>(); // 선언 안하고 List라는 걸 썻다? = 제네릭클레스죠
        // List 다음에 <>에 int가 있으니까 얘는 int를 관리하는 List자료구조가 되는것임
        // 이렇게 선언하고 시스템 컬렉션 제네릭 리스트 에서 제공하는 기능들로 함수를 사용하면
        // 자동으로 2배씩 배열 확장해줌 값을 추가할 때마다. 

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine((newList.Count + 1).ToString() + " Add");
            Console.WriteLine("Capacity:" + newList.Capacity); // 배열의 크기
            Console.WriteLine("Capacity:" + newList.Count); // 자료의 크기
            newList.Add(i);
        }

        Console.WriteLine(" ");
        
        if (newList.Contains(8)) // 리스트에 인자값 8이 있는지 없는지 BOOL값으로 리턴함
        {
            Console.WriteLine("자료내부에 8 있다.");
        }
        if (newList.Contains(9099)) // 리스트에 인자값 8이 있는지 없는지 BOOL값으로 리턴함
        {
            Console.WriteLine("자료내부에 8 있다.");
        }
        else
        {
            Console.WriteLine("9099가 없다.");
        }
        Console.WriteLine(newList[5]); // 5번 인덱스 값을 출력
        // Console.WriteLine(newList[16]); // out of range 터짐 // 

        newList.Remove(10); // 10이 있으면 지운다. 없으면 안지움
        newList.RemoveAt(0); // 첫번째를 지운다.
        // newList.RemoveAll(10); 인자값이 다른 리스트 혹은 배열을 넣어줬을때 각각 비교해서 중복되면
        // 지우는 함수
        newList.RemoveRange(0,3); // 0번째부터 3개 지워라.

        for (int i = 0; i < newList.Count; i++)
        {
            Console.WriteLine(i);
        }
    }
}

