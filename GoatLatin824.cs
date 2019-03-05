namespace GoatLatin824{
	public class Solution {
	
    public string toGoatLatin(string s) {
        //begin with a,e,i,o,u then append "ma" to the end
        //begin with else then remove first letter then append "xma"
        //append 'a' to end of each word per its index
        //I speak Goat Latin => Imaa peaksmaaa oatGmaaaa atinLmaaaaaa
        
        //bring string into array of words, seperated by space
        //transform the words based on the rules
        //concat all the words together to string and return
        HashSet<char> chars=new HashSet<char>();
        chars.Add('a');
        chars.Add('e');
        chars.Add('i');
        chars.Add('o');
        chars.Add('u');
        string [] words=s.Split(" ");
        int index=1;
        string newWords=null;
        foreach (string t in words)
        {
        		if (chars.contains(t[0])){t+="ma";}
        		else{t=t.Substring(1,t.Length-1)+t[0]+"ma";}
        		int times=index;
        		while(times>0)
        		{t+='a';
        		times--;}
        		
        	index++;
        	newWords+=t+' '; 
        }
        
        return newWords.Trim();
    	}
	}
}