using System.Collections.Generic;
using Xunit;

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
        {   string temp=null;
        		if (chars.Contains(t[0])){temp=t+"ma";}
        		else{temp=t.Substring(1,t.Length-1)+t[0]+"ma";}
        		int times=index;
        		while(times>0)
        		{temp+='a';
        		times--;}
        		
        	index++;
        	newWords+=temp+' '; 
        }
        
        return newWords.Trim();
    	}
	}

    public class TestGoatLatin{

        [Fact]
        public void testGoatLatin(){
            Solution s=new Solution();
            string str="I speak Goat Latin";
            Assert.Equal("Imaa peaksmaaa oatGmaaaa atinLmaaaaa",s.toGoatLatin(str));
                
            string str2="The quick brown fox jumped over the lazy dog";
            Assert.Equal("heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa",s.toGoatLatin(str2));
        }

    }
}