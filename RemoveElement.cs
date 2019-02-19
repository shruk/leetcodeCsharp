using Xunit;

namespace RemoveElement{
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int i=0;//starting index
        int j=nums.Length-1;//ending index

        if (nums.Length==0) return 0;
        while (i<j)
        {
            if (val==nums[i])
            {
                if (val==nums[j])
                {
                    //no swap
                    //move j down
                    j--;
                }
                else{
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
        
        if (nums[j]==val)
        {
            return j;
        }
        
        return 1+j;
        
        
        
    }
}

    public class ReverseInteger
    {
        [Fact]
        public void Test1()
        {
        }
    }

}