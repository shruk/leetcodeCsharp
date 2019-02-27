using System;

namespace AddBinary67{

public class Solution{
    //this solution is not working as the input string could be very long, but it is good to know the framework can handle basic converstions.
    public string AddBinary(string a, string b){
    //input is non-empty string}
    //a="11" b="01" sum="100"
    //a is 3 b is 1 sum is 4 
    //one method is to convert them into decimal and add, then convert back
    //convert string to number first
    long ia=Convert.ToInt64(a,2);//convert to 32 bit integer from base 2 string
    long ib=Convert.ToInt64(b,2);
    long sum=ia+ib;
    return Convert.ToString(sum,2); //
    }
	}
}