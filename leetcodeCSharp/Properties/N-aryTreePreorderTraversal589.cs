using System.Collections.Generic;

namespace leetcodeCSharp
{
    public class N_aryTreePreorderTraversal589
    {
        public IList<int> Preorder(Node root)
        {
            IList<int> result = new List<int>();
            Stack<Node> stk = new Stack<Node>();
            if (root == null) return result;

            stk.Push(root);

            while (stk.Count != 0)
            {
                Node temp = stk.Pop();
                for(int i = temp.children.Count-1; i >= 0 ; i--) stk.Push(temp.children[i]);
                result.Add(temp.val);
            }

            return result;
        } 
    }
}