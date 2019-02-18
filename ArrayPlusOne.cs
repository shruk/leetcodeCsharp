using Xunit;

namespace ArrayPlusOne{

public class Solution {
    public int[] PlusOne(int[] digits) {
        
        int len=digits.Length;
        
        Console.Write(len);
        bool moveLeft=false;
        if (digits[len-1]<9)
        {
        digits[len-1]=digits[len-1]+1;}
        else { //LAST DIGIT IS 9
            int i=len-1;
            while (i>=0)
            {
                if (digits[i]==9)
                {digits[i]=0;
                moveLeft=true;}
                else{
                    digits[i]=digits[i]+1;
                    moveLeft=false;break;}
                i--;
            }
            
            
            if (moveLeft==true)
            {//need to assign new array as all digits are 9...
            int[] newArray=new int[len+1];
            newArray[0]=1;
            Array.Copy(digits,0,newArray,1,len);
                return newArray;
            }
            
            
            
        }
        
        return digits;
    }
}

    public class ArrayPlusOne
    {
        [Fact]
        public void Test1()
        {
            //TreeNode node=new TreeNode(1);
            //node.
        }
    }

}