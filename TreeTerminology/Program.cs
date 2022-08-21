
// depth and height

class TreeNode
{
    public int Data { get; set; }
    public TreeNode Parent { get; set; }

    public List<TreeNode> ChildContainer = new List<TreeNode>();
    

    public TreeNode(int _data, TreeNode _Parent = null, List<TreeNode> _ChildContainer = null)
    {

        Data = _data;
        Parent = _Parent;
        ChildContainer = _ChildContainer;
    }

}
class Depth
{

    public int Depth(TreeNode node)
    {
        // 노드가 아무것도 없는경우
        if (node == null)
        {
            Console.WriteLine("Empty");
        }
        else
        {
            node = 
        }
    }
}

// 숙제 Depth height 구현 연습
// 다이나믹어레이 사용
// 코딩테스트 연습문제
