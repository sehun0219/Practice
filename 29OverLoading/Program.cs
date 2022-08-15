enum DAMAGETYPE
{
    Fire,
    Ice,
    Phy  
}


class Player
{
    public Player() // 생성자도 당연히 오버로딩이 된다. 모든 함수에 적용된다. 함수에는 ( 생성자 , 스테틱 , 맴버 함수) 세개 가 있음 
    {

    }
    public Player(int _hp)
    {
        HP = _hp;
    }
    int FireDef = 5;
    int IceDef = 5;
    int AttDef = 5;
    int HP = 100;

    // 사실 이 함수의 이름은 Damage int
    public void Damage(int _Damage) // 함수의 오버로딩
    {
        HP -= _Damage;
    }
    //public void Damage(int _Damage) // 자료형까지 같아야 같은 함수로 인식해서 못만듬
    //{

    //}

    // 이함수의 이름은 Damage int int
    public void Damage(int _Damage, DAMAGETYPE _Type)
    {
        switch (_Type)
        {
            case DAMAGETYPE.Ice:
                _Damage -= IceDef;
                break;
            case DAMAGETYPE.Fire:
                _Damage -= FireDef;
                break;
            case DAMAGETYPE.Phy:
                _Damage -= AttDef;
                break;
            default:
                break;

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NewPlayer.Damage(1, DAMAGETYPE.Ice);
    }
}