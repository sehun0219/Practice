// 형변환 없이 사용하는 리스트
// 제네릭 컬렉션

class List
{
    // Array
    //int[] intArray = new int[5];

    // ArrayList
    // ArrayList arrayList = new ArrayList();

    // int 데이터를 저장하는 리스트 
    // ArrayList와 같음 다만 저장할 데이터 타입을 미리 설정해서 사용함 (형변환없이 사용)
    static void Main(string[] args)
    {
        List<int> intList = new List<int>();
        intList.Add(1);
    }
}

