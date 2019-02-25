

using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace EditDist{ 
class EditDist 
{ 

    public static int [,] dp;
    static int min(int x, int y, int z) 
    { 
        if (x <= y && x <= z) return x; 
        if (y <= x && y <= z) return y; 
        else return z; 
    } 
 
    public static int editDistDP2(Dictionary<int, string> d1,Dictionary<int, string> d2)
    {

        int m=d1.Count;
        int n=d2.Count;
        dp = new int[m + 1,n + 1]; 

            for (int i = 0; i <= m; i++) 
                    { 
                        for (int j = 0; j <= n; j++) 
                        { 
                            // If first collection of string is empty, only option is to 
                            // insert all strings of second collection
                            if (i == 0) 
                                // Min. operations = j 
                                dp[i, j] = j;  
                
                            // If second collection of string is empty, only option is to 
                            // remove all strings of first collection
                            else if (j == 0) 
                                // Min. operations = i 
                                dp[i,j] = i;  
                
                            // If last string are same, ignore last string 
                            // and recur for remaining string 
                            else if (d1[i - 1] == d2[j - 1]) 
                                dp[i, j] = dp[i - 1, j - 1]; 
                
                            // If the last character is different, consider all 
                            // possibilities and find the minimum 
                            else
                                dp[i, j] = 1 + min(dp[i, j - 1], // Insert 
                                                dp[i - 1, j], // Remove 
                                                dp[i - 1, j - 1]); // Replace 
                        } 
                    } 
            
        return dp[m, n]; 


        
    }
    public static int editDistDP(String str1, String str2) 
    { 
        int m=str1.Length;
        int n=str2.Length;
        // Create a table to store 
        // results of subproblems 
        dp = new int[m + 1,n + 1]; 
      
        // Fill d[][] in bottom up manner 
        for (int i = 0; i <= m; i++) 
        { 
            for (int j = 0; j <= n; j++) 
            { 
                // If first string is empty, only option is to 
                // insert all characters of second string 
                if (i == 0) 
                  
                    // Min. operations = j 
                    dp[i, j] = j;  
      
                // If second string is empty, only option is to 
                // remove all characters of first string 
                else if (j == 0) 
                       
                     // Min. operations = i 
                    dp[i,j] = i;  
      
                // If last characters are same, ignore last char 
                // and recur for remaining string 
                else if (str1[i - 1] == str2[j - 1]) 
                    dp[i, j] = dp[i - 1, j - 1]; 
      
                // If the last character is different, consider all 
                // possibilities and find the minimum 
                else
                    dp[i, j] = 1 + min(dp[i, j - 1], // Insert 
                                    dp[i - 1, j], // Remove 
                                    dp[i - 1, j - 1]); // Replace 
            } 
        } 
  
        return dp[m, n]; 
    }

    public static List<string> Back_DP2(int [,]dp, Dictionary<int, string> d1,Dictionary<int, string> d2)
    {
        //if last characters are same, go to dignoly cell, record the step.
        int i=d1.Count;
        int j=d2.Count;
        int value=dp[i,j];
        List<string> li=new List<string>();
                while (value>0)        
                {
                    if(d1[i - 1] == d2[j - 1])
                    {
                        i--;
                        j--;
                    } 
                    else
                    {
                        value=dp[i,j]-1;
                        int minVal=min(dp[i, j - 1], // Insert 
                            dp[i - 1, j], // Remove 
                            dp[i - 1, j - 1]); // Replace

                        if (dp[i,j-1]==minVal)
                        {//insert operation happened
                        li.Add("Inserted "+ d2 [j-1] +"on position "+j.ToString());
                            //Console.WriteLine("inserted "+ str2 [j-1]);
                            j=j-1;
                            //keep record
                        }
                        else if (dp[i-1,j]==minVal)
                        {//remove operation happened
                            li.Add("Removed "+ d1 [i-1]+"on position "+i.ToString());
                            i=i-1;
                            //keep record
                        }else if (dp[i-1,j-1]==minVal)
                        {//replace operation happened
                            li.Add(d1[i-1]+" replaced "+ d2 [j-1]+"on position "+i.ToString());
                            j--;
                            i--;
                            //keep record
                        }

                    }
        }
        return li;
    }
    public static List<string> Back_DP(int [,]dp, string str1, string str2)
    {
        //if last characters are same, go to dignoly cell, record the step.
        int i=str1.Length;
        int j=str2.Length;
        int value=dp[i,j];
        List<string> li=new List<string>();
                while (value>0)        
                {
                    if(str1[i - 1] == str2[j - 1])
                    {
                        i--;
                        j--;
                    } 
                    else
                    {
                        value=dp[i,j]-1;
                        int minVal=min(dp[i, j - 1], // Insert 
                            dp[i - 1, j], // Remove 
                            dp[i - 1, j - 1]); // Replace

                        if (dp[i,j-1]==minVal)
                        {//insert operation happened
                        li.Add("inserted "+ str2 [j-1]);
                            //Console.WriteLine("inserted "+ str2 [j-1]);
                            j=j-1;
                            //keep record
                        }
                        else if (dp[i-1,j]==minVal)
                        {//remove operation happened
                            li.Add("Removed "+ str1 [i-1]);
                            i=i-1;
                            //keep record
                        }else if (dp[i-1,j-1]==minVal)
                        {//replace operation happened
                            li.Add(str1[i-1]+" replaced "+ str2 [j-1]);
                            j--;
                            i--;
                            //keep record
                        }

                    }
        }
        return li;
    }

}

    public class EditDistTest
    {

        private readonly ITestOutputHelper output;


    public EditDistTest(ITestOutputHelper output)
    {
        this.output = output;
    }

        [Fact]
        public void Test1()
        {
           String str1 = "sunday"; 
        String str2 = "saturday"; 
        output.WriteLine(EditDist.editDistDP( str1 , str2 ).ToString());
        List<string> li=EditDist.Back_DP(EditDist.dp, str1,str2 );

        foreach (string s in li)
        {
            output.WriteLine(s);
        }

        
        }


        [Fact]
        public void Test2()
        {
           Dictionary<int,string> d1=new Dictionary<int, string>();
            d1.Add(0,"something");
            d1.Add(1,"red");
            d1.Add(2,"green");
            d1.Add(3,"black");
            d1.Add(4,"red");
            d1.Add(5,"green");

           Dictionary<int,string> d2=new Dictionary<int, string>();
            d2.Add(0,"something");
            d2.Add(1,"green");
            d2.Add(2,"black");
            d2.Add(3,"red");
            d2.Add(4,"green");
            d2.Add(5,"something");
            d2.Add(6,"something");
        
        output.WriteLine(EditDist.editDistDP2( d1 , d2 ).ToString());
        List<string> li=EditDist.Back_DP2(EditDist.dp, d1,d2 );
        li.Reverse();
        foreach (string s in li)
        {
            output.WriteLine(s);
        }

        
        }


    }
}