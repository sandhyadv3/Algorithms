using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Algorithms
{
    public class BinaryTree
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

        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        public int Max(int left, int right)
        {
            return left > right ? left : right;
        }
    }
}
