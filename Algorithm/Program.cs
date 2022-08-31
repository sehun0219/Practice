
// 알고리즘이란 주어진 문제를 어떻게 해결할 것인지..

// 입력 > 처리 > 출력 단계로 생각

// 입력 부분은 자료구조가 담당한다. 간단히는 변수 및 배열의 데이터를 사용하고 
// 컬렉션, 파일, 데이터베이스의 데이터를 사용하는 영역이다.

// 처리는 알고리즘 처리 영역

// 출력은 UI를 담당한다. 일반적으로 콘솔, 데스크톱, 웹, 모바일 등 영역으로 나누어서 가공된 데이터가 출력된다.

// 가장 처음에 배워야 하는 학습용 알고리즘은 
// 최댓값, 최솟값, 합, 자료 수, 평균, 정렬 이 있다. 

// 초급
// sum, count, average, max, min

// 중급
// 최대값을 구하면서 최소값을 구하기
// 최소값을 구하면서 최댓값 구하기

// 고급
// 근사값 NEAR, Rank 순위, Sort 오름차순 내림차순, Serach 특정자료 검색, Merge 병합( 배열 두개를 하나로 합치기)
// Mode 최빈값, Group 특정 항목별로 그룹화하기


// Sum
// n명의 국어점수 중에서 80점인 점수의 합

/**
class SumAlgorithm
{
    static void Main(string[] args)
    {
        int[] scores = { 100, 75, 50, 37, 90, 95 };
        int sum = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] >= 80)
            {
                sum += scores[i];
            }
        }
        Console.WriteLine(sum);
    }
}*/

/**
// Count 알고리즘
// 1 부터 1000까지 정수중 13의 배수는 몇개?
class CountAlgorithm
{
    static void Main(string[] args)
    {
        var num = Enumerable.Range(1, 1_000).ToArray();
        int count = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] % 13 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}*/
/*
class CountAlgorithmByLinq
{
    static void Main(string[] args)
    {
        //var count = Enumerable.Range(1, 1000).Where(n => n % 13 == 0).Count();
        //Console.WriteLine(count);
        var count = Enumerable.Range(1, 1000).Count(n => n %13 == 0);
        Console.WriteLine(count);
    }
}
*/

// Average
// 합계를 카운트로 나누어 평균을구함
// n명의 점수 중에서 80점 이상 95점 이하인 평균
/*
class AverageDemo
{
    static void Main(string[] args)
    {
        int[] arr = { 100, 90, 80, 70, 50, 60 };
        int sum = 0;
        double average = 0;
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 80 && arr[i] <= 95)
            {
                sum = sum + arr[i];
                count++;
            }
            
        }
        Console.WriteLine("총점 : " + sum);
        average = sum / count;
        Console.WriteLine(average);
    }
}*/
/*
class Aver
{
    static void Main(string[] args)
    {
        double aver = (new int[] { 50, 65, 78, 90, 95 }).Where(d => d >= 80 && d <= 95).Average();
        Console.WriteLine(aver);
    }
}*/

/*// Max 배열에서 가장 큰 값을 구한다.

class Max
{
    static void Main(string[] args)
    {
        int max = int.MinValue;
        int[] arr = { -2, -5, -3, -7, -1 };
        for (int i = 0; i < arr.Length; i++)
        {
            if(arr[i] > max)
            {
                max = arr[i];
            } 
        }
        Console.WriteLine($"최댓값(식) : {arr.Max()}");
        Console.WriteLine($"최댓값(문) : {max}");
    }
}*/

// 최소값 Min
/*class Min
{
    static void Main(string[] args)
    {
        var min = Int32.MaxValue;
        int[] num = { 2,5,3,7,1 };
        for (int i = 0; i < num.Length; i++)
        {
            if (num[i] < min && num[i] % 2 == 0)
            {
                min = num[i];
            }
        }
        Console.WriteLine($"짝수 최솟값 (식): {num.Where(n => n % 2 == 0).Min()}");
        Console.WriteLine($"짝수 최솟값 (문): {min}");
    }
}*/

// 근사값 구하기 Near
// 주어진 값과 차이가 가장 적게 나는 값을 구하는 것
// 코드보면서 다시 잘 이해해봐라
// 배열의 모든값의 절대값을 구하는 변수를 만든다.
// 타겟이랑 배열의 모든값을 빼서 가장 작은 절대값을 갖는 인덱스가 근사값이 된다.
/*
class Near
{
    static void Main(string[] args)
    {
        int Abs(int num) => (num < 0) ? -num : num; 
        int min = int.MaxValue;
        int[] num = { 10, 20, 30, 27, 17 };
        int target = 25;
        int near = default;
        for (int i = 0; i < num.Length; i++)
        {
            int abs = Abs(num[i] - target);
            if (abs < min)
            {
                min = abs;
                near = num[i];
            }
                
        }
        var minimum = num.Min(m=>Math.Abs(m-target));
        var closest = num.First(c => Math.Abs(target - c) == minimum);
        Console.WriteLine(closest);
        Console.WriteLine(near);
    }
}*/
// 타겟의 앞뒤로 가까운 숫자 

// 순위 구하기 Rank
/*class Rank
{
    static void Main(string[] args)
    {
        int[] scores = { 90, 87, 100, 95, 80 };
        int[] rankings = Enumerable.Repeat(1,5).ToArray(); // 랭킹 다섯개를 모두 1로 초기화
        for (int i = 0; i < scores.Length; i++)
        {
            rankings[i] = 1;
            for (int j = 0; j < scores.Length; j++)
            {
                if (scores[i] < scores[j])
                {
                    rankings[i]++;  
                }
            }
        }
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"{scores[i]}점은 {rankings[i]} 번째로 높은 점수");
        }
    }
}*/

// 람다식으로 순위 표현하기

//class Rank
//{
//    static void Main(string[] args)
//    {
//        int[] point = { 90, 87, 100, 95, 80 };
//        var rank = point.Select(s => point.Where(ss => ss > s).Count()+1).ToArray();
//        for (int i = 0; i < rank.Length; i++)
//        {
//            Console.Write(rank[i] + " ");
//        }

//    }
//}



/*class Sort // 정렬 알고리즘
    // 정렬알고리즘에는 selection sort, bublle sort, quick sort 등이 있다.
    // 선택정렬만 해봄
    // 데이터 하나를 기준으로 나머지 데이터와 비교하여 가장 작거나 큰 데이터와 자리를 바꾸는 식으로 반복해서 비교한다.
    // 데이터의 개수가 n개면 전체 회전수는 n-1이다. 가장작은수부터 채워나감

    // 전체를 쭉돌고 가장작은값이 0번인덱스로오고 0번이 가장작은값이 있던곳으로감
    // 1번인덱스부터쭉 다시돌고 두번째에 채워짐 다시2번인덱스부터 돌고 세번째 이런식으로 끝까지 채움
{
    static void Main(string[] args)
    {
        List<int>list = new List<int> { 3, 2, 1, 5, 4 };
        int N = list.Count;

        for (int i = 0; i < N - 1; i++)
        {
            for (int j = i + 1 ; j < N; j++)
            {
                if (list[i] > list[j])
                {
                    int temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }
        for (int i = 0; i < N; i++)
        {
            Console.Write(list[i] + " ");
        }
    }
}*/
/*// Linq로 정렬하기
class SortDemo
{
    static void Main(string[] args)
    {
        int[] data = { 3, 2, 1, 5, 4 };
        Array.Sort(data);
        foreach (var item in data)
        {
            Console.WriteLine(item);
        }
    }
}*/

/*// Search알고리즘
// 순차검색(sequential search) 전체 데이터를 처음부터 끝까지 순서대로 검색
// 이진검색(binary search) 정렬된 데이터를 절반으로 나누어서 검색

// 이진검색알고리즘
// 주어진 데이터가 오름차순으로 정렬되어 있다고 가정하자
// 데이터가 정렬되어 있지 않으면 앞에서 배운 정렬알고리즘을 사용해 정렬한 후 이진 검색 알고리즘 로직을 적용해야한다.
// 이진 알고리즘을 divide and conquer 나누기 및 정복 이라고하는데 그 의미대로 데이터를 반으로 나누어 검색해 순차보다 
// 효율이 좋다.

// 중간인덱스를 mid로 놓고 low 인덱스는 0 high 인덱스는 4로 한 후 각 회전마다 중간 인덱스를 구하여 값을 찾는다.

class BinarySearchDemo
{
    static void Main(string[] args)
    {
        int[] data = { 1, 3, 5, 7, 9 };
        int N = data.Length;
        int search = 3;
        bool flag = false;
        int index = -1;

        int low = 0;
        int high = N - 1;
        while (low <= high)
        {
            int mid = (low + high)/2;
            if (data[mid] == search)
            {
                flag = true;
                index = mid;
                break;
            }
            if (data[mid] > search)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        if (flag)
        {
            Console.WriteLine($"{search}는 {index} 위치에 있다. ");
        }
        else
        {
            Console.WriteLine($"{search} 가 배열에 없다.  ");
        }
    }
}*/

/*// 병합 merge 알고리즘
// 병합은 배열 두개를 하나로 합친다.
// 오름차순으로 정렬된 두 정수 배열을 합치기
// first 배열은 1~M, second배열은 1~N 까지 값을 가진다.
// merge 배열은 M + N 개의 배열을 가진다.

class MergeDemo
{
    static void Main(string[] args)
    {
        int[] first = { 1, 3, 5 }; int[] second = { 2, 4 };
        int M = first.Length; int N = second.Length;
        int[] merge = new int[M + N];
        int i = 0; int j = 0; int k = 0;

        while (i < M && j < N)
        {
            if (first[i] <= second[j])
            {
                merge[k++] = first[i++];
            }
            else
            {
                merge[k++] = second[j++];
            }
        }
        while (i < M)
        {
            merge[k++] = first[i++];
        }
        while (j < N)
        {
            merge[k++] = second[j++];
        }
        foreach (var m in merge)
        {
            Console.Write(m + " ");
        }

    }
}

class MergeLinq
{
    static void Main(string[] args)
    {
        int[] first = { 1, 3, 5 };
        int[] second = { 2, 4 };
        int[] merge =
            (from o in first select o).Union(from t in second select t).OrderBy(m => m).ToArray();
        foreach (var item in merge)
        {
            Console.Write(item);
        }
    }
}*/

/*// 최빈값 Mode 알고리즘
// 가장 많이 나타난 값을 의미함.
// 최빈값은 데이터 자체를 배열의 인덱스로 보고 인덱스 개수 알고리즘을 적용함

class ModeDemo
{
    static void Main(string[] args)
    {
        int[] scores = { 1, 3, 4, 3, 5 };
        int[] indexes = new int[5 + 1];
        int max = int.MinValue;
        int mode = 0;

        for (int i = 0; i < scores.Length; i++)
        {
            indexes[scores[i]]++;
        }
        for (int i = 0; i < indexes.Length; i++)
        {
            if (indexes[i] > max)
            {
                max = indexes[i];
                mode = i;
            }
        }
        Console.WriteLine(mode);

    }
}*/

//Group

// 반별로 총점이나 평균, 제품별 판매금액의 합 같은 그룹별로 구분되는 데이터의 통계를 산출할 때 사용합니다.
// 그룹 알고리즘도 미리 정렬이 되어있어야 합니다. 정렬 키에 따라 데이터 출력이 달라짐

class GroupAlgorithm
{
    class Record
    {
        public string Name { get; set; }
        public int Quatitiy { get; set; }
    }
    static void Main(string[] args)
    {
        List<Record> GetAll()
        {
            return new List<Record> 
            {
                new Record{Name = "Radio", Quatitiy = 3},
                new Record{Name = "TV", Quatitiy = 1},
                new Record{Name = "Radio", Quatitiy = 2},
                new Record{Name = "DVD", Quatitiy = 4}
            };
        }
        void PrintData(string message, List<Record> data)
        {
            Console.WriteLine(message);
            foreach(var item in data)
            {
                Console.WriteLine($"{item.Name}-{item.Quatitiy}");
            }
        }
        List<Record> records = GetAll();
        List<Record> groups = new List<Record>();
        int N = records.Count;
        for (int i = 0; i < N-1; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (String.Compare(records[i].Name, records[j].Name)>0)
                {
                    var t = records[i]; 
                    records[i] = records[j]; 
                    records[j] = t;
                }
            }
        }
        int subtotal = 0;
        for (int i = 0; i < N; i++)
        {
            subtotal += records[i].Quatitiy;
            if ((i + 1) == N || (records[i].Name != records[i + 1].Name))
            {
                groups.Add(new Record { Name = records[i].Name, Quatitiy = subtotal });
            };
            subtotal = 0;
        }
        PrintData("[1] 정렬된 원본 데이터: ", records);
        PrintData("[2] 이름으로 그룹화된 데이터: ", groups);
        PrintData("[3] LINQ로 그룹회된 데이터: ", records
            .GroupBy(r => r.Name)
            .Select (g => new Record { Name = g.Key, Quatitiy = g.Sum(n => n.Quatitiy)})
            .ToList());
    }
}
    

