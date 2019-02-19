using Xunit;

namespace RemoveElement{
public class Solution {
    //original solution
    public int RemoveElement(int[] nums, int val) {
        
        int i=0;//starting index
        int j=nums.Length-1;//ending index

        if (nums.Length==0) return 0;
        while (i<=j)
        {
            if (val==nums[i])
            {
                if (val==nums[j])
                {   //no swap
                    //move j down
                    j--;
                }else{
                    //swap with j
                    nums[i]=nums[j];
                    nums[j]=val;
                    i++;
                    j--;
                }
            }
            else 
            {
                i++;
            }
        }
        
        return 1+j;
        
        
        
    }


//solution online, this solution is easier, but performance wise it is not that good.
    public int RemoveElement_Online(int[] nums, int val) {
        
    int i=0;
    int j=0;
        while (j<=nums.Length-1)
        {
            if (val!=nums[j])
            {
                nums[i]=nums[j];
                i++;
            }
            j++;
        }
        return i;
        
    }
    public class RemoveElementTest
    {
        [Fact]
        public void Test1()
        {
        }
    }

}
}