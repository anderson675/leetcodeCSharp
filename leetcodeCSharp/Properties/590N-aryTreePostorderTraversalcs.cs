
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}



using System.ComponentModel.Design.Serialization;

namespace leetcodeCSharp
{
    public class 590N_aryTreePostorderTraversalcs
    {
        public IList<int> Postorder(Node root)
        {
            IList<int> result = new List<int>();
            IList<int> temp = new List<int>();
            
            for (int i = 0; i < root.children.Count; i++)
            {
                temp = Postorder(root.children[i]);
                for (int j = 0; j < temp.Count; j++)
                {
                    result.Append(temp[j]);
                }
            }

            result.Append(root.val);
            return result;

        }
    }
}