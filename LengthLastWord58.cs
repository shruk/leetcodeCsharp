using System;
using Xunit;
namespace LengthLastWord{
	public class Solution {
		//this way uses Split function, kind of high level
		public int lengthOfLastWord(string s) {
    		 if (s.Length==0)return 0;
        
        string [] sArray=s.Split(" ",StringSplitOptions.RemoveEmptyEntries);
        
        
      //  if (s[s.Length-1]==(char)32)
      //      return sArray[sArray.Length-2].Length;
        //Console.Write(sArray[sArray.Length-1]);
				if (sArray.Length==0)return 0;
    		return sArray[sArray.Length-1].Length;
    
    	}
	}


    public class TestLengthLastWord{

        [Fact]
        public void testLength(){
            Solution s=new Solution();
            string str="I speak Goat Latin";
            Assert.Equal(5,s.lengthOfLastWord(str));

						string str2="a ";
            Assert.Equal(1,s.lengthOfLastWord(str2));
                
						string str3="a b    ";
            Assert.Equal(1,s.lengthOfLastWord(str3));
            
           
        }

    }

}