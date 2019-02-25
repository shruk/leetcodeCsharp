using System;
using System.Collections.Generic;
using Xunit;

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

//use hashset, this one is not fast... as the core idea is still the same as naive solution

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

//we need to convert time complexity into space, using a hashtable (Dictionary in c#)
//this solution is better, remember dictionary operation is important!, containsKey, Add, TryGetValue

        public static bool ContainsNearbyDuplicate_Dictionary(int[] nums, int k){
         int i=nums.Length;
         if (i==0)return false;
         Dictionary<int,int> dict=new Dictionary<int, int>();
         int s=0;
         //for each item in array, check if dup is in k range.
         while(s<=i-1){
             int j;
             //check if the same value already in dict
             if (dict.TryGetValue(nums[s],out j))
             {//found, 
                if (s-j<=k&&j!=s)return true;
             }
             
             if (dict.ContainsKey(nums[s]))
             {
                 //replace the old key with new key
                dict[nums[s]]=s;
             }else {
             dict.Add(nums[s],s);
            }
           
            s++;
         }
         return false;
        }

        //another solution to save more spaces via sliding window, using Hashset
         public static bool ContainsNearbyDuplicate_HashSet(int[] nums, int k){
         int i=nums.Length;
         if (i==0)return false;
         HashSet<int> hs=new HashSet<int>();
         int s=0;
         //for each item in array, check if dup is in k range.
         while(s<=i-1){
             
             
           
            s++;
         }
         return false;
        }
    }

        public class ContainsDup219
    {
        [Fact]
        public void Test1()
        {   
            int[] nums=new int[]{1,2,3,1,2,3};
            Assert.False(Solution.ContainsNearbyDuplicate_Dictionary(nums,2));
        }
    }



}