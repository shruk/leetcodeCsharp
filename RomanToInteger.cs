using Xunit;

namespace RomanToInteger
{
public class Solution {
    public static int RomanToInt(string s) {
        int I=1;
        int V=5;
        int X=10;
        int L=50;
        int C=100;
        int D=500;
        int M=1000;
        int result=0;
        for (int i=0;i<s.Length;i++)
        {
            if (s[i].Equals('I'))
            {

                try {                
                if (s[i+1].Equals('V'))
                {result+=4;i+=1;continue;}
                else if (s[i+1].Equals('X'))
                {result+=9;i+=1;continue;}
                else{result+=I;} 
                }catch(System.IndexOutOfRangeException ex)
                {
                   result+=I;
                }
            }
            
            if (s[i].Equals('X'))
            {
                try {  

                if (s[i+1].Equals('L'))
                {result+=40;i+=1;continue;}
                else if (s[i+1].Equals('C'))
                {result+=90;i+=1;continue;}
                else{result+=X;}}
                catch(System.IndexOutOfRangeException ex)
                {
                   result+=X;
                }
            }
            
            if (s[i].Equals('C'))
            {
                 try {  

                if (s[i+1].Equals('D'))
                {result+=400;i+=1;continue;}
                else if (s[i+1].Equals('M'))
                {result+=900;i+=1;continue;}
                else{result+=C;}}
                 catch(System.IndexOutOfRangeException ex)
                {
                   result+=C;
                }
            }
            if (s[i].Equals('V')){result+=V;continue;}
            if (s[i].Equals('L')){result+=L;continue;}
            if (s[i].Equals('D')){result+=D;continue;}
            if (s[i].Equals('M')){result+=M;continue;}
            
        }
        return result;
    }
}

    public class RomanToInteger
    {
        [Fact]
        public void Test1()
        {
              Assert.Equal(3,Solution.RomanToInt("III"));


        }
    }

}