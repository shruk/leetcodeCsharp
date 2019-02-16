using System;
using System.Collections.Generic;

//not a bad solution start initially!
public class Solution{
public bool IsValid(string s) {
        Stack<char> sc=new Stack<char>();
        char [] lbegin=new char[] {'(','{','['};
        char [] lend=new char[] {')','}',']'};
        foreach (char c in s) 
        {
            if (Array.IndexOf(lbegin,c)>-1)
            {
                sc.Push(c);
            }
            if (Array.IndexOf(lend,c)>-1)
            {  
                if (sc.Count==0)
                    return false;
                if (c==')')
                {   
                    if (sc.Peek()=='(')
                    { sc.Pop();}
                    else {return false;}
                }
                if (c=='}')
                {
                    if (sc.Peek()=='{'){sc.Pop();}
                    else {return false;}
                }
                if (c==']')
                {
                    if (sc.Peek()=='['){sc.Pop();}
                    else {return false;}
                }
                }
            
        }
        
        if (sc.Count==0) return true;
        return false;
        
        }
        
    }