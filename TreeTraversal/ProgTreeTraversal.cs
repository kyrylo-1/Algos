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

            prog.PrintPostOrder(prog.MyTreeNode);
            //prog.PrintPreOrder(prog.MyTreeNode);
            //prog.PrintInOrder(prog.MyTreeNode);
        }

        void PrintPostOrder(TreeNode node)
        {
            if (node == null)
                return;

            PrintPostOrder(node.left);
            PrintPostOrder(node.right);

            Console.Write(node.val + " ");
        }

        void PrintPreOrder(TreeNode node)
        {
            if (node == null)
                return;

            Console.Write(node.val + " ");
            PrintPreOrder(node.left);
            PrintPreOrder(node.right);
        }

        void PrintInOrder(TreeNode node)
        {
            if (node == null)
                return;

            PrintInOrder(node.left);
            Console.Write(node.val + " ");
            PrintInOrder(node.right);
        }
    }
}
