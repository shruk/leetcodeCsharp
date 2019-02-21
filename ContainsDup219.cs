using System;
using System.Collections.Generic;

namespace ContainsDup219{

 public class Solution{
//inital solution, bad in terms of performance
     public bool ContainsNearbyDuplicate(int[] nums, int k){
         int i=nums.Length;
         int distance=k+1;
         if (i==0)return false;
         int s=0;
         
         while(s<=i-1){

             for (int j=0;j<nums.Length;j++)
                {
                    if (s!=j&&nums[s]==nums[j])
                    {  
                        distance=Math.Abs(j-s)<distance?Math.Abs(j-s):distance; 
                    }
                    
                }

            s++;
         }
         return k>=distance?true:false;
        }

    // a little faster but not enough
     public bool ContainsNearbyDuplicate2(int[] nums, int k){
         int i=nums.Length;
         int distance=k+1;
         if (i==0)return false;
         int s=0;
         //for each item in array, check if dup is in k range.
         while(s<=i-1){

             for (int j=s-k;j<=s+k;j++)
                {
                    if(j<0||j>i-1){ continue;}

                    if (s!=j&&nums[s]==nums[j])
                    {  
                        return true;
                    }
                    
                }

            s++;
         }
         return false;
        }

        //solution works but requires better performance
         public bool ContainsNearbyDuplicate3(int[] nums, int k){
         int i=nums.Length;
         if (i==0)return false;
         int s=0;
         //for each item in array, check if dup is in k range.
         while(s<=i-1){

             for (int j=s+1;j<=s+k;j++)
                {
                    if(j>i-1){ break;}

                    if (s!=j&&nums[s]==nums[j])
                    {  
                        return true;
                    }
                    
                }

            s++;
         }
         return false;
        }

//use hashset, this one is not fast...

         public bool ContainsNearbyDuplicate_hashset(int[] nums, int k){
         int i=nums.Length;
         if (i==0)return false;
         HashSet<int> hs=new HashSet<int>();
         int s=0;
         //for each item in array, check if dup is in k range.
         while(s<=i-1){

             for (int j=s;j<=s+k;j++)
                {
                    if(j>i-1){ break;}
                    if (!hs.Add(nums[j]))return true;
                    
                    
                }
            hs.Clear();
            s++;
         }
         return false;
        }



    }

}

}