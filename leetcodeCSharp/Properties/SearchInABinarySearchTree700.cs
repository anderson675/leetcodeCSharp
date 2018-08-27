namespace leetcodeCSharp
{
    public class SearchInABinarySearchTree700
    {
         public class TreeNode 
         {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int x) { val = x; }
        }
        public TreeNode SearchBST(TreeNode root, int val) {
            while (root != null)
            {
                if (val>root.val)
                {
                    root = root.right;
                } else if (val < root.val)
                {
                    root = root.left;
                } else if (val == root.val)
                {
                    return root;
                }
            }

            return null;
        } 
    }
}