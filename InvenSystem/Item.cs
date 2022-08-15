using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{
    string mName; // 맴버변수를 퍼블릭으로 공개하는것은 좋은것이 아니다.
    int mGold;    // 그렇다고 쓰지도 않는데 만들 필요는 없다.

    public string Name { get { return mName; } }
    public int Gold { get { return mGold; } }


    // Item들에 이름이 있어야겠죠?
    // 생성자로 아이템 이름이 들어가야 정의가 되게끔 해줍니다.
    public Item (string _Name, int _Gold)
    {
        mName = _Name;
        mGold = _Gold;
    }
}