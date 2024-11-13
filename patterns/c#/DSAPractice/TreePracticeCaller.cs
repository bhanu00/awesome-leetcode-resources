using TreePractice;

namespace DSAPractice
{
    public class TreePracticeCaller
    {
        public static void Main(string[] args)
        {
            TreeNode<int> root;
            MyTree<int> myTree;
            BuildTree(out root, out myTree);

            DFSTraversalRecursively(root, myTree);

            DFSTraversalUsingStack(root, myTree);

            BFSTraversalUsingQueue(root);

            Console.ReadLine();
        }

        private static void DFSTraversalUsingStack(TreeNode<int> root, MyTree<int> myTree)
        {
            // pre order
            IList<TreeNode<int>> stack = new List<TreeNode<int>>();
            Console.WriteLine("DFS Traversal using Stack");
            Stack<TreeNode<int>> st = new Stack<TreeNode<int>>();
            st.Push(root);
            while (st.Count > 0)
            {
                var r = st.Pop();
                Console.WriteLine(r.Data.ToString());
                stack.Add(r);
                if (r.Left != null && !stack.Contains(r.Left))
                {
                    st.Push((TreeNode<int>)r.Left);
                }

                if (r.Right != null && !stack.Contains(r.Right))
                {
                    st.Push(((TreeNode<int>)r.Right));
                }
            }

            // in order

            //post order
        }

        private static void BFSTraversalUsingQueue(TreeNode<int> root)
        {
            Console.WriteLine("BFS Traversal Example using Queue");

            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();

            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var ro = queue.Dequeue();
                Console.WriteLine(ro.Data.ToString());
                if (ro.Left != null)
                {
                    queue.Enqueue(ro.Left);
                }
                if (ro.Right != null)
                {
                    queue.Enqueue(ro.Right);
                }
            }
        }

        private static void DFSTraversalRecursively(TreeNode<int> root, MyTree<int> myTree)
        {
            Console.WriteLine("Pre order traversa");
            myTree.PreOrderTraversal(root);
            Console.WriteLine("In order traversal");
            myTree.InOrderTraversal(root);
            Console.WriteLine("Post order traversal");
            myTree.PostOrderTraversal(root);
        }

        private static void BuildTree(out TreeNode<int> root, out MyTree<int> myTree)
        {
            root = new TreeNode<int>(1);
            root.Left = new TreeNode<int>(2);
            root.Right = new TreeNode<int>(3);

            root.Left.Left = new TreeNode<int>(4);
            root.Left.Right = new TreeNode<int>(5);

            root.Right.Left = new TreeNode<int>(6);
            root.Right.Right = new TreeNode<int>(7);

            myTree = new MyTree<int>();
        }
    }
}
