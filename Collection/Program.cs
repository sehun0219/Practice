﻿// 배열 , 리스트, 컬렉션은 동일하게 취급됨
// 컬렉션 클래스는 데이터 항목의 집합을 메모리 상에서 다루는 클래스
// 문자열 같은 간단한 형태부터 특정 클래스의 집합같은 복잡한 형태도 있음

// 배열 : 일반적으로 숫자처럼 간단한 데이터 형식을 저장함
// 리스트 : 간단한 데이터 형식을 포함한 개체들을 저장함
// 딕셔너리 : 키와 값의 쌍으로 관리되는 개체들을 저장함

// 일반적으로 그룹을 배열로보고 새로운 클래스 그룹을 컬렉션으로 보기도함

// 데이터를 그룹으로 묶어 관리할 때는 일반적으로 배열로 관리함
// 배열은 크기가 고정되어있고 새로운 데이터를 추가할 수 없지만 컬렉션은 가능함

// 컬렉션은 반복해서 사용할 수 있는 크기의 형식을 동적으로 변경할 수 있음
// 데어터의 조회, 정렬, 중복제거, 이름과 값을 쌍으로 관리하는등 여러 장점이 있음

// 닷넷에서 제공하는 컬렉션 클래스로는
// stack 클래스
// queue 클래스
// arraylist 클래스 가 있음

// 스테틱 클레스들과 달리 이런 클래스들은 먼저 인스턴스를 선언해야함

using System.Collections;


class MyClass
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();
        ht[0] = "닷넷코리아";
        ht["닉네임"] = "레드플러스";
        ht["사이트"] = "비주얼아카데미";
        

        foreach (var item in ht.Keys)
        {
            Console.WriteLine(ht[item]);
        }
    }
}