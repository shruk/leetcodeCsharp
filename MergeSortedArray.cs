using System;
using Xunit;

namespace MergeSortedArray{

//we need to keep the old reference of num1, so that's the reason to use copyto
//this solution works just like linked list, but it is not idea since the complexity in logic.
public class Solution {
    public static void Merge(int[] nums1, int m, int[] nums2, int n) {
        //create a new array
        int s=m+n;
        int[] nums3=new int[s];
        nums1.CopyTo(nums3,0);
        int i=0;
        int j=0;
        int k=0;
        while (i<m && j<n)
        {
                if (nums1[i]<nums2[j])
                {
                    nums3[k]=nums1[i];
                    i++;
                }
                else 
                {
                 nums3[k]=nums2[j];
                 j++;
                 }
                k++;
            
            
        }
        
        
        if (i==m&&j<n){Array.Copy(nums2,j,nums3,k,n-j);}
        if (i<m&&j==n){Array.Copy(nums1,i,nums3,k,m-i);}
        nums3.CopyTo(nums1,0);
        
    }

    //solution on line， pay attention to the syntax as well as the logic!
    public static void Merge_Online(int[] nums1, int m, int[] nums2, int n) {
       int k=m+n-1;//index for end of nums1
        int i=m-1;//end index of nums1
        int j=n-1;//end index of nums2
        
        while(i>=0 && j>=0)
        {   nums1[k--]=nums2[j]>nums1[i]?nums2[j--]:nums1[i--]; }
        while(j>=0)
        {nums1[k--]=nums2[j--];}
    }


}
    public class MergeSortedArrayTest
    {
        [Fact]
        public void Test1()
        { int [] nums1=new int[]{1,2,3,0,0,0};
        int m=3;
        int [] nums2=new int[]{2,5,6};
        int n=3;
        Solution.Merge(nums1,m,nums2,n);

        }
    }
}