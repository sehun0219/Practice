using System;

public class Class1
{
	public Class1()
	{
		List<int> newList = new List<int>();
        for (int i = 0; i < 10; i++)
        {
			Console.WriteLine("Capacity:" + newList.Capacity); // 배열의 크기
			Console.WriteLine("Capacity:" + newList.Count); // 자료의 크기
			newList.Add(i);
		}

		

	}
}
