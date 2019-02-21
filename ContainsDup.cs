using System.Collections.Generic;

namespace ContainsDup{

 public class Solution{
//inital solution, not so good in terms of performance
     public bool ContainsDuplicate(int[] nums){
         int i=nums.Length;
         if (i==0)return false;
         int s=0;
         
         while(s<=i-1){

             for (int j=0;j<nums.Length;j++)
                {
                    if (s!=j&&nums[s]==nums[j])
                    {   
                        return true;
                    }
                    
                }

            s++;
         }
         return false;
        }

//using hashset, as only unique value can be stored in hashset so it is more of a hack
    public bool ContainsDuplicate2(int[] nums){
        
        HashSet<int> hs=new HashSet<int>();
        foreach( int i in nums)
        {
                hs.Add(i);
        }
        if (hs.Count!=nums.Length)return true;

        return false;

    }

    //continue use hashset, but use the bool return from add, this one is good, but maybe not enough
    public bool ContainsDuplicate3(int[] nums){
        
        HashSet<int> hs=new HashSet<int>();
        foreach( int i in nums)
        {
               if ( !hs.Add(i)) return true;
        }
        return false;
    }

   }


}