

// 노드 클래스

public class BinaryTreeNode<T>
{
    public T Data { get; set; }
    public BinaryTreeNode<T>[] Left { get; set; }
    public BinaryTreeNode<T>[] Right { get; set; }

    public BinaryTreeNode(T _Data)
    {
        this.Data = _Data;
    }
}


// 이진 트리 클래스
public class BinaryTree<T>
{
    public BinaryTreeNode<T>[] Root { get; private set; }

}