using System;

namespace leetcodeCSharp
{
    public class TrimABinarySearchTree669
    {
        /*
        Definition for a binary tree node.*/
        public class TreeNode 
        {
          public int val;
          public TreeNode left;
          public TreeNode right;
          public TreeNode(int x) { val = x; }
        }
      
        public TreeNode TrimBST(TreeNode root, int L, int R) 
        {
            if (root == null)
            {
                return null;
            }

            if (root.val > R)
            {
                return TrimBST(root.left, L, R);
            }

            if (root.val < L)
            {
                return TrimBST(root.right, L, R);
            }

            root.left = TrimBST(root.left, L, R);
            root.right = TrimBST(root.right, L, R);
            return root;
        } 
    }
 }