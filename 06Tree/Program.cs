
class NLinkExpression
{
    class TreeNode
    {
        public object Data { get; set; }
        public TreeNode[] Links { get; private set; }

        public TreeNode(object _data, int _maxDegree = 3)
        {
            Data = _data;
            Links = new TreeNode[_maxDegree];
        }
    }
    class DynamicTreeNode
    {
        public object Data { get; set; }
        public List<TreeNode> Links { get; private set; }
        public DynamicTreeNode(object _Data)
        {
            Data= _Data;
            Links = new List<TreeNode>();
        }
    }


   




    static void Main(string[] args)
    {
        var A = new TreeNode("A");
        var B = new TreeNode("B");
        var C = new TreeNode("C");
        var D = new TreeNode("D");

        A.Links[0] = B;
        A.Links[1] = C;
        A.Links[2] = D;

        B.Links[0] = new TreeNode("E");
        B.Links[1] = new TreeNode("F");

        D.Links[0] = new TreeNode("G");
        // Child of A
        foreach (var _node in A.Links)
        {
            Console.WriteLine(_node.Data);
        }


        
    }
}
