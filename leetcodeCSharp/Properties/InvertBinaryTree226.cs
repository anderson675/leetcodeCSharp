using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class InvertBinaryTree226
    {
        public class TreeNode
        {
               public int val;
               public TreeNode left;
               public TreeNode right;
               public TreeNode(int x) { val = x; }
        }

        public TreeNode InvertTree(TreeNode root)
        {
            if(root == null)
                return root;
        
            TreeNode temp = root. left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(temp);
        
            return root;
        } 
    }
}