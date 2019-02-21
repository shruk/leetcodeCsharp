using Xunit;

namespace RemoveDup{
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i=0;//slow runner
        int j=1;//fast runner
        if (nums.Length==0) return 0;
        while(j<nums.Length)
        {
            if(nums[i]!=nums[j])
            {nums[++i]=nums[j];}j++;
            
        }
        return i+1;
        
    }
}

    public class RemoveDupTest
    {
        [Fact]
        public void Test1()
        {
        }
    }
}