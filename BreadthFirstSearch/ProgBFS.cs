using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace BreadthFirstSearch
{
    class ProgBFS
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
            var obj = new ProgBFS();
            obj.Search(obj.MyTreeNode, 8);
        }

        void Search(TreeNode root, int value)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            root.PrintNode();

            while (queue.Count > 0)
            {
                TreeNode curr = queue.Dequeue();
                if (curr == null)
                    continue;

                if (curr.val == value)
                {
                    Console.Write("\nFIND ITEM!    ");
                    curr.PrintNode();
                    return;
                }

                if (curr.left != null)
                    queue.Enqueue(curr.left);

                if (curr.right != null)
                    queue.Enqueue(curr.right);
            }
        }

    }
}
