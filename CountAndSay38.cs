using System;
using Xunit;

namespace CountAndSay
{
    public class Solution{
        public static string CountAndSay(int n)
        {
        
        //1 read as one 1 or 11
        //11 read as 2 1s or 21
        //21 read as one 2 1 1 or 1211
        //1211 read as one 1 one 2 2 1 or 111221
        //111221 read as 3 1 2 2 one 1 or 312211
        //312211 read s 13 11 22 2 1
        int i=2;
        if (n==1) {return "1";}
        else{
           string nextStr="1";
        		while(i<=n)
        		{
        		  nextStr=read(nextStr);
              i++;
        		}
            return nextStr;
        	}
         
        }
        
        
        
        private static string read(string n)
        {//read each char of n from left to right and return a new string
        //the rule is read current char and next, if same go to one more
        //else print out number of times repitition and the char itself
        string result=null;
        int rep=1;
        for (int i=0;i<n.Length;i++)
        	{
        		if(i==n.Length-1){//last digits,
             string first = rep.ToString();
        		 string second= n[i].ToString();
        		 result+=first+second;
        		break;
            	}
        		if(n[i]==n[i+1]){//rep happens
        		rep++;}
        		else{//need to print it out
        		 string first = rep.ToString();
        		 string second= n[i].ToString();
        		 result+=first+second;
             rep=1;
        		}	
        	}
        
        return result;
        }
    }

    
    public class CountAndSay
    {
        [Fact]
        public void Test1()
        {
            Solution.CountAndSay(121);
        }
    }
}