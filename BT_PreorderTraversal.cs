
using System.Collections.Generic;
using Xunit;
/**
* Definition for a binary tree node.*/
public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
     public TreeNode(int x) { val = x; }
 }
 
 //original solution, using recursive
public class Solution {
    IList<int> li=new List<int>();
    
    public IList<int> PreorderTraversal(TreeNode root) {
            //1.process 2. go left, 3 go right
           TreeNode current=root;
           
        
           if (current!=null)
           {
               process(current,li);
               PreorderTraversal(current.left);
               PreorderTraversal(current.right);
           }
        
        return li;
        
    }
    
    
    public void process(TreeNode current,IList<int> li)
    {
        li.Add(current.val);
    }
}


    public class BT_PreorderTraversal
    {
        [Fact]
        public void Test1()
        {
            //TreeNode node=new TreeNode(1);
            //node.
        }
    }