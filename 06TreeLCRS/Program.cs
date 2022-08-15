class LCRSNode // Left Child Right Sibling Expression, LCRS
{
    public object Data { get; set; }
    public LCRSNode LeftChild { get; set; }
    public LCRSNode RightSibling { get; set; }

    public LCRSNode(object _data)
    {
        this.Data = _data;
    }

}

class LCRSTree
{
    public LCRSNode Root { get; private set; }
    public LCRSTree(object _RootData)
    {
        this.Root = new LCRSNode(_RootData);
    }

    // AddChild();
    // 1. 부모노드를 입력 파라미터로 받는다. 
    // 2. 왼쪽자식노드가 null이면 왼쪽 노드에 추가하고 
    // 3. null이 아니면 노드에 있는 오른쪽 형제노드를 계속 따라가다가
    // 4. 마지막 형제노드 다음에 자식노드를 추가한다.
    // 5. 추가된 child를 리턴한다. 
    public LCRSNode AddChild(LCRSNode _Parent, object _Data)
    {
        if (_Parent == null)
        {
            return null;
        }
        LCRSNode child = new LCRSNode(_Data);
        if (_Parent.LeftChild == null)
        {
            _Parent.LeftChild = child;
        }
        else
        {
            var node = _Parent.LeftChild;
            while (node.RightSibling != null)
            {
                node = node.RightSibling;
            }
            node.RightSibling = child;
        }
        return child;
    }


    // AddSibling(); 
    // 1. 만들고자하는 형제노드의를 노드 클래스에서 불러옴 그 데이터는 널이 아니어야함
    // 2. 오른쪽으로 계속 가서 마지막 형제노드변수에  (오른쪽 형제노드 지시 반복)
    // 3. 형제 노드를 객체화 하고 객체화 된 변수를 새로운 형제 변수로 정의
    // 4. 새로 정의된 형제노드를 리턴
    public LCRSNode AddSibling(LCRSNode _Node, object _Data)
    {
        if (_Node == null)
        {
            return null;  
        }
        while (_Node.RightSibling != null)
        {
            _Node = _Node.RightSibling;
        }

        var sibling = new LCRSNode(_Data);
        _Node.RightSibling = sibling;

        return sibling;
    }

    //PrintLevelOrder(); // 레벨순으로 위에서부터 가로방향으로 트리노드를 출력하는 메서드
    // * Concept
    // 각 레벨의 형제노드를 출력하면서, 노드중에 자식노드가 있는 노드들을 Queue에 담아둔다.
    // 형제노드가 모두 출력되면 (즉, 한 레벨의 노드가 모두 출력되면) Queue에있는 자식노드를 위와 동일한 
    // 방법으로 출력한다. 
 
    public void PrintLevelOrder()
    {
        var q = new Queue<LCRSNode>();
        q.Enqueue(this.Root);

        while (q.Count > 0)
        {
            var node = q.Dequeue();
            while (node != null)
            {
                Console.Write($"{node.Data} ");
                if (node.LeftChild != null)
                {
                    q.Enqueue(node.LeftChild);
                }
                node = node.RightSibling;
            }
        }
    }

    //PrintIndentTree(); 
    //Concept
    //한라인씩 출력.
    //노드의 레벨에 따라 레벨 1인 노드는 앞에 공백하나
    //노드의 레벨이 2인 노드는 공백 두개를 주는 방식으로 앞에 들여쓰기를 함
    //부모노드를 먼저 출력하고 자식노드는 들여쓰기를 하나 추가해서 PrintIndentTree()를 재귀호출해서 사용
    //오른쪽 형제노드는 같은 레벨이므로 동일한 계층의 들여쓰기로 재귀호출함
    
    public void PrintIndentTree()
    {
        PrintIndent(this.Root, 1);
    }

    private void PrintIndent(LCRSNode _Node, int _Indent) 
    {
        if(_Node == null) { return; }
        
        // print node
        string pad = " ".PadLeft(_Indent);
        Console.WriteLine($"{pad}{_Node.Data}");

        // for LeftChild (자식노드니까 Indent +1)
        PrintIndent(_Node.LeftChild, _Indent +1);

        // for RightSibling (형제노드니까 Indent)
        PrintIndent(_Node.RightSibling, _Indent);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var A = new LCRSNode("A");
        var B = new LCRSNode("B");
        var C = new LCRSNode("C");
        var D = new LCRSNode("D");
        var E = new LCRSNode("E");
        var F = new LCRSNode("F");
        var G = new LCRSNode("G");

        A.LeftChild = B;
        B.RightSibling = C;
        C.RightSibling = D;
        B.LeftChild = E;
        E.RightSibling = F;
        D.LeftChild = G;

        // Child of A
        if (A.LeftChild != null)
        {
            var temp = A.LeftChild;
            Console.WriteLine(temp.Data);

            while (temp.RightSibling != null)
            {
                temp = temp.RightSibling;
                Console.WriteLine(temp.Data);
            }
        }


        Console.WriteLine("========== Indent Test =========");
        LCRSTree lCRSTree = new LCRSTree("A");
        var IndentA = lCRSTree.Root;
        var IndentB = lCRSTree.AddChild(IndentA,"B");
        lCRSTree.AddChild(IndentA, "C");
        var IndentD = lCRSTree.AddSibling(IndentB, "D");
        lCRSTree.AddChild(IndentB, "E");
        lCRSTree.AddChild(IndentB, "F");
        lCRSTree.AddChild(IndentD, "G");

        lCRSTree.PrintIndentTree();
        lCRSTree.PrintLevelOrder();


    }
}




