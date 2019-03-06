namespace LengthLastWord{
	public class Solution {
		public int lengthOfLastWord(string s) {
    		 if (s.Length==0)return 0;
        
        string [] sArray=s.Split(" ");
        
        
        if (s[s.Length-1]==' ')
            return 0;
        Console.Write(sArray[sArray.Length-1]);
    		return sArray[sArray.Length-1].Length;
    
    	}
	}
}