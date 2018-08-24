using System;

namespace leetcodeCSharp
{
    public class MaximumDepthOfNaryTree559
    {
        
        
        // Definition for a Node.
        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node()
            {
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public int MaxDepth(Node root) 
        {
            if (root == null)
            {
                return 0;
            }

            int result = 1;
            foreach (Node child in root.children)
            {
                result = Math.Max(result, MaxDepth(child) + 1);
            }

            return result;
        } 
    }
}