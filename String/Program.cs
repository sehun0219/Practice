string message = "hello, world";
Console.WriteLine(message.ToUpper());
Console.WriteLine(message.ToLower());
Console.WriteLine(message.Replace("hello", "hi"));
Console.WriteLine(message.Replace("hello", "hello fucking").TrimStart().TrimEnd().Trim());

String s1 = "안녕하세요.";
String s2 = "반갑습니다.";
Console.WriteLine(s1 + s2);

char[] charArray = { 'a', 'b', 'c' };
String str = new String(charArray);
Console.WriteLine(str);

string s3 = "Hello";
string s4 = "하이";
Console.WriteLine(s3.Length);
Console.WriteLine(s4.Length);

string s5 = "Hello";
string s6 = " world";
string s7 = String.Concat(s5 + s6);
Console.WriteLine(s7);

string a = "hello";
char[] ch = a.ToCharArray();

for (int i = 0; i < a.Length; i++)
{
    Console.Write($"{ch[i]}\t");
}
