using System.Collections.Generic;
using System.Linq;

namespace leetcodeCSharp
{
    public class AverageOfLevelsInBinaryTree637
    {
        public IList<double> AverageOfLevels(TreeNode root) 
        {
            List<double> res = new List<double>();
            if (root == null) return res;
            Queue<TreeNode> myQueue = new Queue<TreeNode>();
            myQueue.Enqueue(root);

            while (myQueue.Any())
            {
                int size = myQueue.Count;
                double sum = 0;
                for (int i = 0; i < size; i++)
                {
                    TreeNode T = myQueue.Dequeue();
                    sum += T.val;
                    if(T.left != null) myQueue.Enqueue(T.left);
                    if(T.right != null) myQueue.Enqueue(T.right);
                }
                res.Add(sum/size);
            }

            return res;
        } 
    }
}