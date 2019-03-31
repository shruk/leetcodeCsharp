namespace LongestCommonPrefix{
	public class solution{
		public string LongestCommonPrefix(string [] str)
		{
			 string com="";
        if (str.Length==0) return "";
        
	        com=str[0];		
			foreach (string s in str)
			{
				com=common(com,s);
			}
			
			
			return com;
		}
		
		
		private string common(string com,string s)
		{int minlen=com.Length>s.Length?s.Length:com.Length;
			for (int i=0;i<minlen;i++)
			{
				if (com[i]!=s[i])
				{return com.Substring(0,i);}
			}
            return com;
		}
	}
	
}