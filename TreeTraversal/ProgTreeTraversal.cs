using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    class ProgTreeTraversal
    {
        TreeNode MyTreeNode
        {
            get
            {
                var trNRoot = new TreeNode(15);
                var trN9 = new TreeNode(9);
                var trN3 = new TreeNode(3);
                var trN8 = new TreeNode(8);
                var trN12 = new TreeNode(12);
                var trN23 = new TreeNode(23);
                var trN17 = new TreeNode(17);
                var trN28 = new TreeNode(28);

                trNRoot.left = trN9;
                trNRoot.right = trN23;

                trN9.left = trN3;
                trN9.right = trN12;

                trN3.right = trN8;

                trN23.left = trN17;
                trN23.right = trN28;

                return trNRoot;
            }
        }

        static void Main(string[] args)
        {
            var prog = new ProgTreeTraversal();

            Console.WriteLine("==========POST Order===============");
            prog.PrintPostOrder(prog.MyTreeNode);
            Console.WriteLine("\nIteratively");
            prog.PrintPostOrderIteratively(prog.MyTreeNode);

            Console.WriteLine("\n\n==========PRE ORDER===============");
            prog.PrintPreOrder(prog.MyTreeNode);
            Console.WriteLine("\nIteratively");
            prog.PrintPreOrderIteratively(prog.MyTreeNode);

            Console.WriteLine("\n\n==========IN ORDER===============");
            prog.PrintInOrder(prog.MyTreeNode);
            Console.WriteLine("\nIteratively");
            prog.PrintInOrderIteratively(prog.MyTreeNode);
        }

        #region POSTORDER
        void PrintPostOrder(TreeNode node)
        {
            if (node == null)
                return;

            PrintPostOrder(node.left);
            PrintPostOrder(node.right);

            Console.Write(node.val + " ");
        }

        void PrintPostOrderIteratively(TreeNode root)
        {
            if (root == null)
                return;

            var list = new LinkedList<int>();

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                TreeNode curr = stack.Pop();
                list.AddFirst(curr.val);

                if (curr.left != null)
                    stack.Push(curr.left);
               
                if (curr.right != null)
                    stack.Push(curr.right);                
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
        #endregion

        #region PREORDER
        void PrintPreOrder(TreeNode node)
        {
            if (node == null)
                return;

            Console.Write(node.val + " ");
            PrintPreOrder(node.left);
            PrintPreOrder(node.right);
        }

        void PrintPreOrderIteratively(TreeNode root)
        {
            if (root == null)
                return;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Any())
            {
                root = stack.Pop();
                Console.Write(root.val + " ");

                if (root.right != null)
                    stack.Push(root.right);

                if (root.left != null)
                    stack.Push(root.left);
            }
        }
        #endregion

        #region INORDER
        void PrintInOrder(TreeNode node)
        {
            if (node == null)
                return;

            PrintInOrder(node.left);
            Console.Write(node.val + " ");
            PrintInOrder(node.right);
        }

        void PrintInOrderIteratively(TreeNode root)
        {
            if (root == null)
                return;

            var stack = new Stack<TreeNode>();
            TreeNode pre = null;

            while (root != null || stack.Any())
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                Console.Write(root.val + " ");

                pre = root;
                root = root.right;
            }
        }
        #endregion
    }
}
