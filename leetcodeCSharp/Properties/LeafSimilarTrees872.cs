﻿using System.Collections.Generic;

namespace leetcodeCSharp
{    

    public class LeafSimilarTrees872
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
        public List<int> SearchTree(TreeNode node, List<int> values)
        {
            if(node != null)
            {
                if(node.left == null && node.right == null){
                    values.Add(node.val);
                }
                SearchTree(node.left, values);
                SearchTree(node.right, values);
            }
            return values;
        }

        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var treeValues1 = new List<int>();
            SearchTree(root1, treeValues1);
            var treeValues2 = new List<int>();
            SearchTree(root2, treeValues2);
               
            return treeValues1.SequenceEqual(treeValues2);
        }
 
    }
}