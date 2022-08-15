﻿// 네임스페이스 이름, 클래스 이름, 변수 이름 같은건 한글을 사용하지 않는다. 
// 모든 시스템들은 영어의 코드로 작성되었기 때문에 한글처리가 완벽하지 않음.


//보통 게임을 만들 때 클래스는 큰 개념임 내용을 채워야함
// 플레이어라는 클래스의 세부내용을 적어보면
// Gold를 가지고있음
// 스텟같은것도 큰 개념
// 경험치
// 공격력
// 방어력
// 대부분이 명사임 클래스로 개념을 만들고 거기에 세부내용인데 명사인것들은 대부분 맴버변수가됨




// 개념 : 플레이어가 있다
// 세부속성 : 값을 가지는 것들 = 멤버변수가 됨

// 맴버변수의 선언은
// int(자료형) 이름(식별자)
// 선언을 하고 초기화 할 수 있다. = 리터럴 초기화

// 맴버변수란..
// exe 파일을 실행하면 이 프로그램은 램에 복사된다.
// 램은 수많은 셀이 있고 그 셀의 번호가 있는데 변수는 할당된 번호를 의미하고 
// int 는 4바이트를 사용하는 타입입니다 라고 말하는 것임. 그리고 변수의 벨류는 주소에
// 할당된 값을 의미함


// 프로그램 실행의 원리
// 1. 공짜가 없음 (메모리를 지불한다)
// 2. 


class Player
{
    
    int gold = 10;
    int exp = 1000;
    int att = 100;
    int def = 200;
    int hp = 500;

}