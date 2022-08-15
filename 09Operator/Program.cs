

class Player
{
    int HP = 100;
    void Damage(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    public int Plus (int _left, int _right)
    {
         int result =_left + _right;
        return result;
    }

    bool ReturnTrue()
    {
        return true;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player();
        


        int result = 0;
        int left = 7;
        int right = 3;

        // = 대입연산자
        // 함수에서 리턴된 값이나 혹은 연산된 값을 넣어라

        //산술 연산자
        player.Plus(10, 20);
        result = player.Plus(left, right);
        Console.WriteLine(result);
        result = left + right; 
        result = left - right;
        result = left * right;
        result = left / right;
        result = left % right;
        // 나누기와 나머지는 0을 넣으면 안됨 컴퓨터에서는 아에 오류가 남
        // */% 가 먼저 되고 +-가 나중에 된다. 괄호 처주면 괄호가 먼저 됨.

        // 비교연산자
        // 비교연산자는 논리형으로 리턴이 되는데 
        // 논리형은 bool이라는 타입이 있다.
        // bool은 true or false 만리턴할 수 있다. 

        bool bResult = true;
        bResult = false;

        bResult = left > right;
        bResult = left < right;
        bResult = left >= right;
        bResult = left <= right;
        bResult = left == right;
        bResult = left != right;

        // bool 논리 연산자
        bResult = true && false; // and 둘다 true 일때만 ture
        bResult = true || false; // or 하나만 true 면 true
        bResult = true ^ false; // xor 양쪽이 같으면 true 하나라도 다르면 false
        bResult = !true; //  true 면 false를 리턴
        bResult = !false; // false 면 ture를 리턴

        // 축약 연산자
        result = 0;
        result += 10; // result = result + 10;
        result -= 10;
        result /=10;
        result *=10;

    }
}