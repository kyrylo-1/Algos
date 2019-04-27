using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TreeNode
    {
        public int val;
        public bool isVisited;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }

        public void PrintNode()
        {
            this.Print();
            //Console.WriteLine("Value: " + val + " _LefVal: " + (left == null ? "null" : left.val.ToString())
            //     + " _RightVal: " + (right == null ? "null" : right.val.ToString()));
        }
    }
}
