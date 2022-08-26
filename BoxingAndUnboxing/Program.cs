int i = 1234;
object obj = i;
Console.WriteLine(obj);

// 스텍 메모리 영역에 저장된 값 형식의 데이터를 힙 메모리 영역에 저장하는 단계를 거처 시간과 공간이 소비되는 비용이 발생함

object o = 1234;
int ii = (int) o;
Console.WriteLine(ii);