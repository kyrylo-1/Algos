using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace TreeInsertDelete
{
    class ProgTreeInsertDel
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
            var prog = new ProgTreeInsertDel();
            prog.MyTreeNode.Print();

            //int numbInsert = 100;
            //TreeNode root = prog.Insert(prog.MyTreeNode, numbInsert);
            //Console.WriteLine("After insert: " + numbInsert);

            //root.Print();
            //root = prog.Insert(prog.MyTreeNode, 1);
            //Console.WriteLine("After insert: 1");
            //root.Print();

            TreeNode rootRem = prog.Remove(prog.MyTreeNode, 23);
        }

        TreeNode Insert(TreeNode root, int data)
        {
            TreeNode curr = root;
            TreeNode parent = null;

            while (curr != null)
            {
                if (data > curr.val)
                {
                    parent = curr;
                    curr = curr.right;
                }

                else
                {
                    parent = curr;
                    curr = curr.left;
                }
            }

            if (parent == null)
            {
                Console.WriteLine("Tree is empty");
                return null;
            }

            else
            {
                if (data > parent.val)
                {
                    parent.right = new TreeNode(data);
                }

                else
                {
                    parent.left = new TreeNode(data);
                }
            }

            return root;
        }

        /// <summary>
        /// https://msdn.microsoft.com/en-us/library/ms379572(v=vs.80).aspx
        /// </summary>
        TreeNode Remove(TreeNode root, int data)
        {
            if (root == null)
                return null;

            TreeNode curr = root;
            TreeNode parent = null;

            while (curr.val != data)
            {
                if (curr.val > data)
                {
                    // current.Value > data, if data exists it's in the left subtree
                    parent = curr;
                    curr = curr.left;
                }
                else if (curr.val < data)
                {
                    // current.Value < data, if data exists it's in the right subtree
                    parent = curr;
                    curr = curr.right;
                }

                if (curr == null)
                    return null;
            }

            // We now need to "rethread" the tree
            // CASE 1: If current has no right child, then current's left child becomes
            //         the node pointed to by the parent

            if (curr.right == null)
            {
                if (parent == null)
                    root = curr.left;

                else
                {
                    if (parent.val > curr.val)
                        // parent.Value > current.Value, so make current's left child a left child of parent
                        parent.left = curr.left;

                    else if (parent.val < curr.val)
                        // parent.Value < current.Value, so make current's left child a right child of parent
                        parent.right = curr.left;
                }
            }

            // CASE 2: If current's right child has no left child, then current's right child
            //         replaces current in the tree
            else if (curr.right.left == null)
            {
                curr.right.left = curr.left;

                if (parent == null)
                    root = curr.right;

                else
                {
                    if (parent.val > curr.val)
                        // parent.Value > current.Value, so make current's right child a left child of parent
                        parent.left = curr.right;

                    else if (parent.val < curr.val)
                        // parent.Value < current.Value, so make current's right child a right child of parent
                        parent.right = curr.right;
                }
            }

            // CASE 3: If current's right child has a left child, replace current with current's
            //          right child's left-most descendent
            else
            {
                // We first need to find the right node's left-most child
                TreeNode leftmost = curr.right.left;
                TreeNode lmParent = curr.right;
                while (leftmost.left != null)
                {
                    lmParent = leftmost;
                    leftmost = leftmost.left;
                }

                // the parent's left subtree becomes the leftmost's right subtree
                lmParent.left = leftmost.right;

                // assign leftmost's left and right to current's left and right children
                leftmost.left = curr.left;
                leftmost.right = curr.right;

                if (parent == null)
                    root = leftmost;
                else
                {
                    if (parent.val > curr.val)
                        // parent.Value > current.Value, so make leftmost a left child of parent
                        parent.left = leftmost;
                    else if (parent.val < curr.val)
                        // parent.Value < current.Value, so make leftmost a right child of parent
                        parent.right = leftmost;
                }
            }

            return root;
        }
    }
}
