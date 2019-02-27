namespace ContainerWater{

//naive solution, performance is not good enough
public class Solution {
    public int MaxArea(int[] height) {
        int i=0;
        int j=1;
        int maxArea=0;
        int n=height.Length;
        while(i<=n-2)
        {
            j=i+1;
            while(j<=n-1)
            {
                int temp=(j-i)*min(height[j],height[i]);
                maxArea= maxArea<temp?temp:maxArea;
                
                
                j++;
            }
                i++;
        }
        return maxArea;
    }
    
    private int min(int x, int y)
    {
        return x<y?x:y;
    }
}
}