namespace TreePractice
{
    public class TreeNode<T>
    {
        public T Data { get; set; }

        public TreeNode(T data)
        {
            Data = data;
        }
        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }
    }

    public class MyTree<T>
    {
        public MyTree()
        {
        }

        #region Recursive methods to traverse tree
        public void InOrderTraversal(TreeNode<T> node)
        {
            if (node == null)
                return;

            InOrderTraversal(node.Left);
            Console.WriteLine(node.Data?.ToString());
            InOrderTraversal(node.Right);
        }

        public void PreOrderTraversal(TreeNode<T> node)
        {
            if (node == null)
                return;

            Console.WriteLine(node.Data?.ToString());
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }

        public void PostOrderTraversal(TreeNode<T> node)
        {
            if (node == null)
                return;

            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.WriteLine(node.Data?.ToString());
        }

        #endregion
    }
}
